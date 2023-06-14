using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static AirPortSchdeuler.services.CalcService;
using System.Linq;
using System.Threading.Tasks;

namespace AirPortSchdeuler.data
{
	public class Flight
	{
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
		public int FlightDurationMinutes { get; private set; }
		public string FlightDurationTime => $"{TimeSpan.FromMinutes(FlightDurationMinutes):HH:mm} H";

		public decimal DistanceKM
		{
			get
			{
				if (Departure == null || Arrival == null) { return 0; }
				return CalcHaversineDistance(Departure, Arrival);
			}
		}

		public Flight(AirPort departure, DateTime departureTime, AirPort arrival, DateTime arrivalDateTime)
		{
			Departure = departure;
			DepartureTime = departureTime;
			Arrival = arrival;
			ArrivalDateTime = arrivalDateTime;
		}
		public override string ToString()
		{
			return $"DEPARTURE : ({Departure.AirPortCode} - {Departure.City}) {DepartureTime:yyyy-MM-d HH:mm} - ARRIVAL({Arrival.AirPortCode} - {Arrival.City}) {ArrivalDateTime:yyyy-MM-dd HH:mm} : DISTANCE {DistanceKM} KM";
		}

	}
}