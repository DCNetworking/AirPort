#if DEBUG
IRepository repo = new DevRepository();
#else
IRepository repo = new Repository();
#endif

AirPort? Mexico = repo.GetAirport(AirPortCode.MEX);
List<AirPort>? allWithLetterA = repo.GetAirport("united");
System.Console.WriteLine(Mexico.ToString());

foreach (AirPort airport in allWithLetterA)
{
	System.Console.WriteLine(airport.ToString());
}

Flight flight = new(repo.GetAirport(AirPortCode.FRA), DateTime.Now, repo.GetAirport(AirPortCode.LAX), DateTime.Now.AddHours(10));
System.Console.WriteLine(flight.ToString());