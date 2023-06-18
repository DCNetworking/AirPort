using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirPortSchdeuler.data
{
    public class Repository : IRepository
    {
        private APContext _ctx;

        public AirPlane GetAirplane(AirPlaneType airplaneType)
        {
            throw new NotImplementedException();
        }

        public AirPlane GetAirplaneToFlight(Flight flight)
        {
            throw new NotImplementedException();
        }

        public List<AirPort> GetAirport(string value)
        {
            throw new NotImplementedException();
        }

        public AirPort GetAirport(AirPortCode airportCode)
        {
            throw new NotImplementedException();
        }

        public List<Flight> GetAllFlights()
        {
            throw new NotImplementedException();
        }

        public List<Flight> GetFlight(FlightSearchDto flightSearchDto)
        {
            throw new NotImplementedException();
        }
    }
}
