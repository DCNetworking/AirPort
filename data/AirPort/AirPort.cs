using System.Runtime.Serialization;
using System.Text;
using System;
namespace AirPortSchdeuler.data;
public class AirPort : IGeometrical
{
	public AirPortCode AirPortCode { get; set; }
	public int AirPortCodeId => (int)AirPortCode;
	public string City { get; set; } = string.Empty;
	public string Country { get; set; } = string.Empty;
	public string Name { get; set; } = string.Empty;
	public string TimeZone { get; set; } = string.Empty;
	public decimal Latitude { get; set; }
	public decimal Longitude { get; set; }
	public override string ToString()
	{
		return $"({AirPortCode}) - {City,-12} {Country,-15} '{Name}'";
	}
}

// AirPortCode = AirPortCode.ATL,
// City = "Atlanta",
// Country = "United States",
// Name = "Hartsfield-Jackson Atlanta International Airport",
