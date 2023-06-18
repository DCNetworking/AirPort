using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirPortSchdeuler.data
{

	public interface IRepository
	{
		List<AirPort> GetAirport(string value);
		AirPort GetAirport(AirPortCode airportCode);
		AirPlane GetAirplane(AirPlaneType airplaneType);
		AirPlane GetAirplaneToFlight(Flight flight);
		List<Flight> GetAllFlights();
		List<Flight> GetFlight(FlightSearchDto flightSearchDto);
	}
}