using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirPort.AirPlane;

public class AirPlane
{
	public AirPlaneType Type { get; set; }
	public int TypeId => (int)Type;
	public string? Name { get; set; }
	public string? Producer { get; set; }
}
