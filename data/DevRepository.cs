using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirPortSchdeuler.data;
using Microsoft.EntityFrameworkCore;

namespace AirPortSchdeuler.data
{
	public class DevRepository : IRepository
	{
		private readonly APContext _ctx;

		public DevRepository()
		{
			Console.WriteLine($"Init from {this.GetType().Name}");
			_ctx = new APContext();
		}

		public AirPort GetAirport(AirPortCode airportCode)
		{
			return _ctx.airPortManager
				.GetAll()
				.FirstOrDefault(ap => ap.AirPortCode == airportCode, new AirPort());
		}

		public List<AirPort> GetAirport(string fragment)
		{
			fragment = fragment.ToLower();
			return _ctx.airPortManager
				.GetAll()
				.Where(ap => ap.ToString().ToLower().Contains(fragment))
				.ToList();
		}

		public AirPlane GetAirplane(AirPlaneType airplaneType)
		{
			return _ctx.airPlaneManager
				.GetAll()
				.FirstOrDefault(ap => ap.Type == airplaneType, new AirPlane());
		}

		public AirPlane GetAirplaneToFlight(Flight flight)
		{
			var result = _ctx.airPlaneManager
				.GetAll()
				.Where(airPlane => FlightService.CalcIsAcceptablePlanesToFlight(flight, airPlane))
				.OrderBy(airPlane =>
				{
					return FlightService.CostPerPassenger(flight, airPlane);
				});
			return result.FirstOrDefault();
		}

		public List<Flight> GetAllFlights()
		{
			return _ctx.flightsManager.GetAll();
		}

		public List<Flight> GetFlight(FlightSearchDto flightSearchDto)
		{
			List<Flight> flights = _ctx.flightsManager
				.GetAll()
				.Where(
					flight =>
						flight.Departure.AirPortCode == flightSearchDto.Departure.AirPortCode
						&& flight.DepartureDateTime.Date.CompareTo(
							flightSearchDto.DepartureDateTime.Date
						) >= 0
				)
				.ToList();
			flights = flights
				.Where(
					flight =>
						flight.Arrival.AirPortCode == flightSearchDto.Arrival.AirPortCode
						&& flight.ArrivalDateTime.Date.CompareTo(
							flightSearchDto.ArrivalDateTime.Date
						) >= 0
				)
				.ToList();
			return flights;
		}
	}
}
