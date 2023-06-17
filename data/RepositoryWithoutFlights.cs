using System;
namespace AirPortSchdeuler.data
{
    public class RepositoryWithoutFlights
    {

        private APContextWithoutFlights _ctx;

        public RepositoryWithoutFlights()
        {
            System.Console.WriteLine($"Init from {this.GetType().Name}");
            _ctx = new APContextWithoutFlights();
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
            .Where(airPlane => flight.DistanceKM / airPlane.MaxSpeed * airPlane.FuelWeightKgUsage1H < (airPlane.FuelWeightKgTankCapacity * (1 - AirPlane.LandingFuelReserve)))
            .OrderBy(airPlane => flight.DistanceKM / airPlane.MaxSpeed * airPlane.FuelWeightKgUsage1H);
            return result.FirstOrDefault();
        }
    }

}

