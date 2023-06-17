using System;
namespace AirPortSchdeuler.data
{
    public class APContextWithoutFlights
    {
        public AirPlaneManager airPlaneManager;
        public AirPortManager airPortManager;
        public APContextWithoutFlights()
        {
            airPlaneManager = AirPlaneManager.Init;
            airPortManager = AirPortManager.Init;
        }
    }
}

