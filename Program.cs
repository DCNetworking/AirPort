#if DEBUG
IRepository repo = new DevRepository();
#else
IRepository repo = new Repository();
#endif

// AirPort? Mexico = repo.GetAirport(AirPortCode.MEX);
// List<AirPort>? allWithLetterA = repo.GetAirport("united");
// System.Console.WriteLine(Mexico.ToString());

// foreach (AirPort airport in allWithLetterA)
// {
// 	System.Console.WriteLine(airport.ToString());
// }

Flight flight = new(
		repo.GetAirport(AirPortCode.LAX),
		DateTime.Now,
		repo.GetAirport(AirPortCode.FRA),
		repo
		);
Flight flight2 = new(
		repo.GetAirport(AirPortCode.FRA),
		flight.ArrivalDateTime.AddHours(1),
		repo.GetAirport(AirPortCode.SYD),
		repo
		);
Console.WriteLine(flight.ToString());
Console.WriteLine(flight2.ToString());
