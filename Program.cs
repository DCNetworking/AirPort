#if DEBUG
using System.Data;
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
		repo.GetAirport(AirPortCode.SYD)
		);
Console.WriteLine(flight.ToString());
flight.SetFilghtDelay(2.5);
flight.SetFilghtDelay(2.5);
flight.SetFilghtDelay(2.5);
