#if DEBUG
IRepository repo = new DevRepository();
#else
IRepository repo = new Repository();
#endif


var flightsSchedule = repo.GetAllFlights();
foreach (Flight flight in flightsSchedule)
{
    Console.WriteLine($"{flight.FlightId} from {flight.Departure.City} ({flight.Departure.AirPortCode}) to {flight.Arrival.City} ({flight.Arrival.AirPortCode})");
}