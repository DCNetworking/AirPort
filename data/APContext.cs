using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AirPortSchdeuler.data
{
    public class APContext : DbContext
    {
        public AirPlaneManager airPlaneManager;
        public AirPortManager airPortManager;
        public FlightsManager flightsManager;
        public APContext()
        {
            airPlaneManager = AirPlaneManager.Init;
            airPortManager = AirPortManager.Init;
            flightsManager = FlightsManager.Init;
        }
    }
}