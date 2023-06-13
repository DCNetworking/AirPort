namespace AirPort.AirPort;
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
		return $"({AirPortCode}) | {City} | {Country} | {Name}";
	}
}

// AirPortCode = AirPortCode.ATL,
// City = "Atlanta",
// Country = "United States",
// Name = "Hartsfield-Jackson Atlanta International Airport",
