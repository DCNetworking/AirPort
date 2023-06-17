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
		public DateTime DepartureTime { get; private set; }
		[Required]
		public AirPort? Arrival { get; private set; }
		[Required]
		public DateTime ArrivalDateTime { get; private set; }
		[Required]
		public AirPlane? AirPlane { get; private set; }
		[Required]
		public string FlightDurationTime { get; private set; }
		public FlightStatusType FlightStatusType { get; private set; }
		public Flight(AirPort departure, DateTime departureTime, AirPort arrival, IRepository repo)
		{

			FlightId = Guid.NewGuid().ToString();
			Departure = departure;
			DateTime DepartureDateTimeWithoutTimeZone = departureTime;
			TimeZoneInfo departureTimeZone = TimeZoneInfo.FindSystemTimeZoneById(departure.TimeZone);
			DepartureTime = TimeZoneInfo.ConvertTime(departureTime, departureTimeZone);
			Arrival = arrival;
			FlightStatusType = FlightStatusType.Ok;
			try
			{
				AirPlane = repo.GetAirplaneToFlight(this);
			}
			catch (Exception)
			{
				throw new Exception(MsgService.PlaneNotFoundForFlight(DistanceKM));
			}
			double timeToAdd = (double)DistanceKM / (double)AirPlane.MaxSpeed;
			DateTime ArrivalDateTimeWithoutTimeZone = departureTime.AddHours((double)timeToAdd);
			TimeZoneInfo arrivalTimeZone = TimeZoneInfo.FindSystemTimeZoneById(arrival.TimeZone);
			ArrivalDateTime = TimeZoneInfo.ConvertTime(ArrivalDateTimeWithoutTimeZone, arrivalTimeZone);
			FlightDurationTime = (ArrivalDateTimeWithoutTimeZone - DepartureDateTimeWithoutTimeZone).ToString(@"hh\:mm");
			Console.WriteLine(MsgService.FlightStatusMsg(FlightId, FlightStatusType));
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
			return $"Flight ID : {FlightId}\nDEPARTURE : ({Departure.AirPortCode} - {Departure.City}) {DepartureTime:yyyy-MM-d HH:mm}\nARRIVAL   : ({Arrival.AirPortCode} - {Arrival.City}) {ArrivalDateTime,-15:yyyy-MM-dd HH:mm}\nDISTANCE {DistanceKM} KM\nDURATION TIME {FlightDurationTime}\nPlane {AirPlane.Name}";
		}
	}
}