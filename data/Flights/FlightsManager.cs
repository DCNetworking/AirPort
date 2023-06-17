using System;
namespace AirPortSchdeuler.data
{
    public class FlightsManager
    {
        private readonly List<Flight> flights;
        private readonly static Lazy<FlightsManager> flightsManager = new(() => new FlightsManager());
        public static FlightsManager Init
        {
            get => flightsManager.Value;
        }
        public List<Flight> GetAll()
        {
            return flights;
        }
        private FlightsManager()
        {
            AirPortManager ap = AirPortManager.Init;
            var repo = new RepositoryWithoutFlights();
            flights = new();
            DateTime now = DateTime.Now;
            flights.Add(new Flight(ap[AirPortCode.LAX], now.AddHours(4.3728), ap[AirPortCode.FRA], repo));
            flights.Add(new Flight(ap[AirPortCode.PEK], now.AddHours(9.8388), ap[AirPortCode.GRU], repo));
            flights.Add(new Flight(ap[AirPortCode.MEX], now.AddHours(8.7456), ap[AirPortCode.CAN], repo));
            flights.Add(new Flight(ap[AirPortCode.SVO], now.AddHours(6.5592), ap[AirPortCode.LHR], repo));
            flights.Add(new Flight(ap[AirPortCode.CDG], now.AddHours(2.1864), ap[AirPortCode.ATL], repo));
            flights.Add(new Flight(ap[AirPortCode.BKK], now.AddHours(20.7708), ap[AirPortCode.MAD], repo));
            flights.Add(new Flight(ap[AirPortCode.ORD], now.AddHours(12.0252), ap[AirPortCode.SYD], repo));
            flights.Add(new Flight(ap[AirPortCode.HKG], now.AddHours(19.6776), ap[AirPortCode.MUC], repo));
            flights.Add(new Flight(ap[AirPortCode.DEL], now.AddHours(22.9572), ap[AirPortCode.IST], repo));
            flights.Add(new Flight(ap[AirPortCode.GRU], now.AddHours(13.1184), ap[AirPortCode.CDG], repo));
            flights.Add(new Flight(ap[AirPortCode.LAX], now.AddHours(16.398), ap[AirPortCode.PEK], repo));
            flights.Add(new Flight(ap[AirPortCode.CAN], now.AddHours(17.4912), ap[AirPortCode.MEX], repo));
            flights.Add(new Flight(ap[AirPortCode.MUC], now.AddHours(23.823), ap[AirPortCode.SVO], repo));
            flights.Add(new Flight(ap[AirPortCode.LHR], now.AddHours(15.3048), ap[AirPortCode.HKG], repo));
            flights.Add(new Flight(ap[AirPortCode.SYD], now.AddHours(11.0296), ap[AirPortCode.DEL], repo));
            flights.Add(new Flight(ap[AirPortCode.FRA], now.AddHours(10.932), ap[AirPortCode.BKK], repo));
            flights.Add(new Flight(ap[AirPortCode.IST], now.AddHours(7.6524), ap[AirPortCode.ORD], repo));
            flights.Add(new Flight(ap[AirPortCode.ATL], now.AddHours(5.466), ap[AirPortCode.LAX], repo));
            flights.Add(new Flight(ap[AirPortCode.CDG], now.AddHours(18.5844), ap[AirPortCode.PEK], repo));
            flights.Add(new Flight(ap[AirPortCode.HKG], now.AddHours(21.864), ap[AirPortCode.MEX], repo));
            flights.Add(new Flight(ap[AirPortCode.SVO], now.AddHours(3.2796), ap[AirPortCode.CAN], repo));
            flights.Add(new Flight(ap[AirPortCode.CDG], now.AddHours(5.466), ap[AirPortCode.ATL], repo));
            flights.Add(new Flight(ap[AirPortCode.ORD], now.AddHours(7.6524), ap[AirPortCode.SYD], repo));
            flights.Add(new Flight(ap[AirPortCode.HKG], now.AddHours(8.7456), ap[AirPortCode.MUC], repo));
            flights.Add(new Flight(ap[AirPortCode.DEL], now.AddHours(9.8388), ap[AirPortCode.IST], repo));
            flights.Add(new Flight(ap[AirPortCode.GRU], now.AddHours(10.932), ap[AirPortCode.CDG], repo));
            flights.Add(new Flight(ap[AirPortCode.LAX], now.AddHours(12.0252), ap[AirPortCode.PEK], repo));
            flights.Add(new Flight(ap[AirPortCode.CAN], now.AddHours(13.1184), ap[AirPortCode.MEX], repo));
            flights.Add(new Flight(ap[AirPortCode.MUC], now.AddHours(14.2116), ap[AirPortCode.SVO], repo));
            flights.Add(new Flight(ap[AirPortCode.LHR], now.AddHours(15.3048), ap[AirPortCode.HKG], repo));
            flights.Add(new Flight(ap[AirPortCode.SYD], now.AddHours(16.398), ap[AirPortCode.DEL], repo));
            flights.Add(new Flight(ap[AirPortCode.FRA], now.AddHours(17.4912), ap[AirPortCode.BKK], repo));
            flights.Add(new Flight(ap[AirPortCode.IST], now.AddHours(18.5844), ap[AirPortCode.ORD], repo));
            flights.Add(new Flight(ap[AirPortCode.ATL], now.AddHours(19.6776), ap[AirPortCode.LAX], repo));
            flights.Add(new Flight(ap[AirPortCode.CDG], now.AddHours(20.7708), ap[AirPortCode.PEK], repo));
            flights.Add(new Flight(ap[AirPortCode.HKG], now.AddHours(21.864), ap[AirPortCode.MEX], repo));
            flights.Add(new Flight(ap[AirPortCode.DEL], now.AddHours(22.9572), ap[AirPortCode.SVO], repo));
            flights.Add(new Flight(ap[AirPortCode.GRU], now.AddHours(24.0504), ap[AirPortCode.LHR], repo));
            flights.Add(new Flight(ap[AirPortCode.LAX], now.AddHours(25.1436), ap[AirPortCode.FRA], repo));
            flights.Add(new Flight(ap[AirPortCode.BKK], now.AddHours(26.2368), ap[AirPortCode.CAN], repo));
            flights.Add(new Flight(ap[AirPortCode.SYD], now.AddHours(27.33), ap[AirPortCode.GRU], repo));
            flights.Add(new Flight(ap[AirPortCode.CAN], now.AddHours(28.4232), ap[AirPortCode.LAX], repo));
            flights.Add(new Flight(ap[AirPortCode.FRA], now.AddHours(29.5164), ap[AirPortCode.HKG], repo));
            flights.Add(new Flight(ap[AirPortCode.IST], now.AddHours(30.6096), ap[AirPortCode.MUC], repo));
            flights.Add(new Flight(ap[AirPortCode.MEX], now.AddHours(31.7028), ap[AirPortCode.SVO], repo));
            flights.Add(new Flight(ap[AirPortCode.PEK], now.AddHours(32.796), ap[AirPortCode.CDG], repo));
            flights.Add(new Flight(ap[AirPortCode.GRU], now.AddHours(33.8892), ap[AirPortCode.ATL], repo));
            flights.Add(new Flight(ap[AirPortCode.CDG], now.AddHours(34.9824), ap[AirPortCode.PEK], repo));
            flights.Add(new Flight(ap[AirPortCode.HKG], now.AddHours(36.0756), ap[AirPortCode.MEX], repo));
            flights.Add(new Flight(ap[AirPortCode.DEL], now.AddHours(37.1688), ap[AirPortCode.SVO], repo));
            flights.Add(new Flight(ap[AirPortCode.LAX], now.AddHours(38.262), ap[AirPortCode.GRU], repo));
            flights.Add(new Flight(ap[AirPortCode.CAN], now.AddHours(39.3552), ap[AirPortCode.CDG], repo));
            flights.Add(new Flight(ap[AirPortCode.MUC], now.AddHours(40.4484), ap[AirPortCode.LAX], repo));
            flights.Add(new Flight(ap[AirPortCode.LHR], now.AddHours(41.5416), ap[AirPortCode.PEK], repo));
            flights.Add(new Flight(ap[AirPortCode.SYD], now.AddHours(42.6348), ap[AirPortCode.HKG], repo));
            flights.Add(new Flight(ap[AirPortCode.GRU], now.AddHours(43.728), ap[AirPortCode.DEL], repo));
            flights.Add(new Flight(ap[AirPortCode.CDG], now.AddHours(44.8212), ap[AirPortCode.MUC], repo));
            flights.Add(new Flight(ap[AirPortCode.IST], now.AddHours(45.9144), ap[AirPortCode.SVO], repo));
            flights.Add(new Flight(ap[AirPortCode.BKK], now.AddHours(47.0076), ap[AirPortCode.CAN], repo));
            flights.Add(new Flight(ap[AirPortCode.MEX], now.AddHours(48.1008), ap[AirPortCode.GRU], repo));
            flights = flights.Where(flight => flight.ArrivalDateTime != default).ToList();
        }
    }
}


