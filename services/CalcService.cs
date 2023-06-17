
namespace AirPortSchdeuler.services
{
	public class CalcService
	{
		public static decimal CalcHaversineDistance(IGeometrical point1, IGeometrical point2)
		{
			if (point1 != null && point2 != null)
			{
				const double radiusOfEarth = 6371; // in kilometers
				double lat1 = DegreesToRadians(point1.Latitude);
				double lon1 = DegreesToRadians(point1.Longitude);
				double lat2 = DegreesToRadians(point2.Latitude);
				double lon2 = DegreesToRadians(point2.Longitude);
				double deltaLon = Math.Abs((double)lon2 - (double)lon1);
				double distance = Math.Acos(Math.Sin(lat1) * Math.Sin(lat2) +
				Math.Cos(lat1) * Math.Cos(lat2) * Math.Cos(deltaLon)) * radiusOfEarth;
				if (lon1 > lon2 && deltaLon > Math.PI)
				{
					distance = 2 * Math.PI * radiusOfEarth - distance;

				}
				return Math.Round((decimal)distance, 2);

			}
			return 0;
		}
		private static double DegreesToRadians(decimal degrees)
		{
			return (double)degrees * Math.PI / 180;
		}
	}
}