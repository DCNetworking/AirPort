#if DEBUG
IRepository repo = new DevRepository();
#else
IRepository repo = new Repository();
#endif


List<Flight> findFlight = repo.GetFlight(new FlightSearchDto(repo.GetAirport(AirPortCode.BKK), DateTime.Now, repo.GetAirport(AirPortCode.CAN), DateTime.Now));
foreach (Flight flight in findFlight)
{
	System.Console.WriteLine(flight.ToString());
}