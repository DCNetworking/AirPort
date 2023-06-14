using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirPortSchdeuler.services
{
    public class CalcService
    {
        public static decimal CalcHaversineDistance(IGeometrical point1, IGeometrical point2)
        {
            if (point1 != null && point2 != null)
            {
                const double R = 6371;
                double lat1Rad = DegreesToRadians(point1.Latitude);
                double lon1Rad = DegreesToRadians(point1.Longitude);
                double lat2Rad = DegreesToRadians(point2.Latitude);
                double lon2Rad = DegreesToRadians(point2.Longitude);
                double dlon = lon2Rad - lon1Rad;
                double dlat = lat2Rad - lat1Rad;
                double a = Math.Sin(dlat / 2) * Math.Sin(dlat / 2) +
                       Math.Cos(lat1Rad) * Math.Cos(lat2Rad) *
                       Math.Sin(dlon / 2) * Math.Sin(dlon / 2);
                double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
                decimal distance = (decimal)(R * c);
                return Math.Round(distance, 2);
            }
            return 0;
        }
        private static double DegreesToRadians(decimal degrees)
        {
            return (double)degrees * Math.PI / 180;
        }
    }
}