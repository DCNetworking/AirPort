using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirPortSchdeuler.data
{
	public class Repository : IRepository
	{
		private APContext _ctx;

		public Repository()
		{
			System.Console.WriteLine($"Init from {this.GetType().Name}");
			_ctx = new APContext();
		}

		public AirPort GetAirport(AirPortCode airportCode)
		{
			return _ctx.airPortManager
			.GetAll()
			.FirstOrDefault(ap => ap.AirPortCode == airportCode, new AirPort());
		}
		public AirPlane GetAirplane(AirPlaneType airplaneType)
		{
			return _ctx.airPlaneManager
			.GetAll()
			.FirstOrDefault(ap => ap.Type == airplaneType, new AirPlane());
		}
		public List<AirPort> GetAirport(string fragment)
		{
			fragment = fragment.ToLower();
			return _ctx.airPortManager
			.GetAll()
			.Where(ap => ap.ToString().ToLower().Contains(fragment))
			.ToList();
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
