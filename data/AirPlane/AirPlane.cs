using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirPortSchdeuler.data;

public class AirPlane
{
	public static readonly decimal LandingFuelReserve = 0.1M;
	public AirPlaneType Type { get; set; }
	public int TypeId => (int)Type;
	public string? Name { get; set; }
	public string? Producer { get; set; }
	public short MaxSpeed { get; set; }
	public decimal FuelWeightKgUsage1H { get; set; }
	public decimal FuelWeightKgTankCapacity { get; set; }
	public decimal MaxFlightTimeHours => FuelWeightKgTankCapacity / FuelWeightKgUsage1H;
	public short PassengersCapacity { get; set; }

}
