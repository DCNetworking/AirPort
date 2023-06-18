using System;
using System.ComponentModel.DataAnnotations;

using static AirPortSchdeuler.services.CalcService;

namespace AirPortSchdeuler.data
{
    public class Flight
    {
        public string FlightId { get; private set; }
        [Required]
        public AirPort? Departure { get; private set; }
        [Required]
        public DateTime DepartureDateTime { get; private set; }
        [Required]
        public AirPort? Arrival { get; private set; }
        [Required]
        public DateTime ArrivalDateTime { get; private set; }
        [Required]
        public AirPlane? AirPlane { get; private set; }
        [Required]
        public string FlightDurationTime { get; private set; }
        public FlightStatusType FlightStatusType { get; private set; }
        public Flight(AirPort departure, DateTime departureDateTime, AirPort arrival, RepositoryWithoutFlights repo)
        {
            Departure = departure;
            DateTime DepartureDateTimeWithoutTimeZone = departureDateTime;
            TimeZoneInfo departureTimeZone = TimeZoneInfo.FindSystemTimeZoneById(departure.TimeZone);
            DepartureDateTime = TimeZoneInfo.ConvertTime(departureDateTime, departureTimeZone);
            Arrival = arrival;
            FlightStatusType = FlightStatusType.Ok;
            try
            {
                FlightId = RenderFlightId();
                AirPlane = repo.GetAirplaneToFlight(this);
                double timeToAdd = (double)DistanceKM / (double)AirPlane.MaxSpeed;
                DateTime ArrivalDateTimeWithoutTimeZone = departureDateTime.AddHours((double)timeToAdd);
                TimeZoneInfo arrivalTimeZone = TimeZoneInfo.FindSystemTimeZoneById(arrival.TimeZone);
                ArrivalDateTime = TimeZoneInfo.ConvertTime(ArrivalDateTimeWithoutTimeZone, arrivalTimeZone);
                FlightDurationTime = (ArrivalDateTimeWithoutTimeZone - DepartureDateTimeWithoutTimeZone).ToString(@"hh\:mm");
                Console.WriteLine(MsgService.FlightStatusMsg(FlightId, FlightStatusType));
            }
            catch (Exception)
            {

            }
        }
        public string RenderFlightId()
        {
            return $"{Departure.AirPortCode.ToString()}-{(new Random()).Next(1000, 9999)}";
        }
        public void SetFilghtDelay(double hours)
        {
            if (FlightStatusType == FlightStatusType.Cancelled)
            {
                Console.WriteLine(MsgService.FlightCancelledMsg(FlightId));
            }
            else
            {
                FlightStatusType = FlightStatusType.Delayed;
                Console.WriteLine(MsgService.FlightStatusMsg(FlightId, FlightStatusType));
                ArrivalDateTime = ArrivalDateTime.AddHours(hours);
                Console.WriteLine(MsgService.FlightArrivalTimeChange(FlightId, ArrivalDateTime));
            }
        }
        public void SetFilghtCancelled()
        {
            if (FlightStatusType == FlightStatusType.Cancelled)
            {
                Console.WriteLine(MsgService.FlightCancelledMsg(FlightId));
            }
            else
            {
                FlightStatusType = FlightStatusType.Cancelled;
                Console.WriteLine(MsgService.FlightStatusMsg(FlightId, FlightStatusType));
                ArrivalDateTime = default;
                Console.WriteLine(MsgService.FlightArrivalTimeChange(FlightId, ArrivalDateTime));
            }
        }
        public decimal DistanceKM
        {
            get
            {
                if (Departure == null || Arrival == null) { return 0; }
                return CalcHaversineDistance(Departure, Arrival);
            }
        }

        public override string ToString()
        {
            return $"----------------------------" +
                    $"\nFlight ID : {FlightId}\n" +
                    $"DEPARTURE : ({Departure.AirPortCode} - {Departure.City}) {DepartureDateTime:yyyy-MM-d HH:mm}\n" +
                    $"ARRIVAL   : ({Arrival.AirPortCode} - {Arrival.City}) {ArrivalDateTime,-15:yyyy-MM-dd HH:mm}\n" +
                    $"DISTANCE {DistanceKM} KM\nDURATION TIME {FlightDurationTime}\n" +
                    $"Plane {AirPlane.Name}\n" +
                    $"---------------------------";
        }
    }
}