using System.Runtime.Serialization;
using System.Text;
using System;
namespace AirPortSchdeuler.AirPort;
public class AirPort
{
	public AirPortCode AirPortCode { get; set; }
	public int AirPortCodeId => (int)AirPortCode;
	public string? City { get; set; }
	public string? Country { get; set; }
	public string? Name { get; set; }
	public string? TimeZone { get; set; }
	public override string ToString()
	{
		return $"({AirPortCode}) - {City,-12} {Country,-15} '{Name}'";
	}
}

// AirPortCode = AirPortCode.ATL,
// City = "Atlanta",
// Country = "United States",
// Name = "Hartsfield-Jackson Atlanta International Airport",
