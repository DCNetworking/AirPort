#if DEBUG
IRepository repo = new DevRepository();
#else
IRepository repo = new Repository();
#endif

var Mexico = repo.GetAirport(AirPortCode.MEX);
var allWithLetterA = repo.GetAirport("united");
System.Console.WriteLine(Mexico.ToString());

foreach (AirPort airport in allWithLetterA)
{
	System.Console.WriteLine(airport.ToString());
}