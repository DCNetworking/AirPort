using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirPortSchdeuler.services
{
	public class FlightService
	{
		public static readonly decimal FuelLiterWeight = 0.8M;
		public static readonly decimal FuelPricePerLiterUSD = 2.5M;
		public static readonly decimal FuelPricePerKgUSD = FuelPricePerLiterUSD * FuelLiterWeight;
		public static decimal CostPerPassenger(Flight flight, AirPlane airPlane)
		{
			return airPlane.PassengersCapacity != 0 ? FuelPricePerKgUSD * (flight.DistanceKM / airPlane.MaxSpeed * airPlane.FuelWeightKgUsage1H) / airPlane.PassengersCapacity : 0;
		}
		public static bool CalcIsAcceptablePlanesToFlight(Flight flight, AirPlane airPlane)
		{
			return (flight.DistanceKM / airPlane.MaxSpeed * airPlane.FuelWeightKgUsage1H) < (airPlane.FuelWeightKgTankCapacity * (1 - AirPlane.LandingFuelReserve)) && airPlane.PassengersCapacity != 0;
		}
	}
}