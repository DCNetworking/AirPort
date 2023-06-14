using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirPortSchdeuler.data;

public class AirPortManager
{
	private readonly List<AirPort> AirPortsList;
	readonly static Lazy<AirPortManager> airPortManager = new(() => new AirPortManager());
	public static AirPortManager Init
	{
		get => airPortManager.Value;
	}

	public List<AirPort> GetAll()
	{
		return AirPortsList;
	}

	private AirPortManager()
	{
		AirPortsList = new()
		{
			new AirPort
			{
				AirPortCode = AirPortCode.ATL,
				City = "Atlanta",
				Country = "United States",
				Name = "Hartsfield-Jackson Atlanta International Airport",
				TimeZone = "America/New_York",
				Latitude = 33.6407M,
				Longitude = -84.4277M
			},
			new AirPort
			{
				AirPortCode = AirPortCode.PEK,
				City = "Beijing",
				Country = "China",
				Name = "Beijing Capital International Airport",
				TimeZone = "Asia/Shanghai",
				Latitude = 40.0799M,
				Longitude = 116.6031M
			},
			new AirPort
			{
				AirPortCode = AirPortCode.FRA,
				City = "Frankfurt",
				Country = "Germany",
				Name = "Frankfurt Airport",
				TimeZone = "Europe/Berlin",
				Latitude = 50.0530018M,
				Longitude = 8.5703726M
			},
			new AirPort
			{
				AirPortCode = AirPortCode.CAN,
				City = "Guangzhou",
				Country = "China",
				Name = "Guangzhou Baiyun International Airport",
				TimeZone = "Asia/Shanghai",
				Latitude = 23.3924M,
				Longitude = 113.2988M
			},
			new AirPort
			{
				AirPortCode = AirPortCode.BKK,
				City = "Bangkok",
				Country = "Thailand",
				Name = "Suvarnabhumi Airport",
				TimeZone = "Asia/Bangkok",
				Latitude = 13.6929M,
				Longitude = 100.7518M
			},
			new AirPort
			{
				AirPortCode = AirPortCode.SVO,
				City = "Moscow",
				Country = "Russia",
				Name = "Sheremetyevo International Airport",
				TimeZone = "Europe/Moscow",
				Latitude = 55.9726M,
				Longitude = 37.4149M
			},
			new AirPort
			{
				AirPortCode = AirPortCode.CDG,
				City = "Paris",
				Country = "France",
				Name = "Paris Charles de Gaulle Airport",
				TimeZone = "Europe/Paris",
				Latitude = 49.0097M,
				Longitude = 2.5479M
			},
			new AirPort
			{
				AirPortCode = AirPortCode.MAD,
				City = "Madrid",
				Country = "Spain",
				Name = "Adolfo Suárez Madrid–Barajas Airport",
				TimeZone = "Europe/Madrid",
				Latitude = 40.4681M,
				Longitude = -3.5676M
			},
			new AirPort
			{
				AirPortCode = AirPortCode.DEL,
				City = "Delhi",
				Country = "India",
				Name = "Indira Gandhi International Airport",
				TimeZone = "Asia/Kolkata",
				Latitude = 28.5562M,
				Longitude = 77.1000M
			},
			new AirPort
			{
				AirPortCode = AirPortCode.ORD,
				City = "Chicago",
				Country = "United States",
				Name = "O'Hare International Airport",
				TimeZone = "America/Chicago",
				Latitude = 41.9742M,
				Longitude = -87.9073M
			},
			new AirPort
			{
				AirPortCode = AirPortCode.GRU,
				City = "Sao Paulo",
				Country = "Brazil",
				Name = "Sao Paulo-Guarulhos International Airport",
				TimeZone = "America/Sao_Paulo",
				Latitude = -23.4356M,
				Longitude = -46.4731M
			},
			new AirPort
			{
				AirPortCode = AirPortCode.LAX,
				City = "Los Angeles",
				Country = "United States",
				Name = "Los Angeles International Airport",
				TimeZone = "America/Los_Angeles",
				Latitude = 34.05223M,
				Longitude =  -118.24368M
			},
			new AirPort
			{
				AirPortCode = AirPortCode.HKG,
				City = "Hong Kong",
				Country = "Hong Kong",
				Name = "Hong Kong International Airport",
				TimeZone = "Asia/Hong_Kong",
				Latitude = 22.3080M,
				Longitude = 113.9185M
			},
			new AirPort
			{
				AirPortCode = AirPortCode.IST,
				City = "Istanbul",
				Country = "Turkey",
				Name = "Istanbul Airport",
				TimeZone = "Europe/Istanbul",
				Latitude = 41.2756M,
				Longitude = 28.7519M
			},
			new AirPort
			{
				AirPortCode = AirPortCode.LHR,
				City = "London",
				Country = "United Kingdom",
				Name = "Heathrow Airport",
				TimeZone = "Europe/London",
				Latitude = 51.4700M,
				Longitude = -0.4543M
			},
			new AirPort
			{
				AirPortCode = AirPortCode.MEX,
				City = "Mexico City",
				Country = "Mexico",
				Name = "Benito Juárez International Airport",
				TimeZone = "America/Mexico_City",
				Latitude = 19.4361M,
				Longitude = -99.0719M
			},
			new AirPort
			{
				AirPortCode = AirPortCode.MUC,
				City = "Munich",
				Country = "Germany",
				Name = "Munich Airport",
				TimeZone = "Europe/Berlin",
				Latitude = 48.3537M,
				Longitude = 11.7861M
			},
			new AirPort
			{
				AirPortCode = AirPortCode.SYD,
				City = "Sydney",
				Country = "Australia",
				Name = "Sydney Airport",
				TimeZone = "Australia/Sydney",
				Latitude = -33.9399M,
				Longitude = 151.1753M
			}
		};
		AirPortsList = AirPortsList.OrderBy(p => p.Country).ThenBy(p => p.City).ToList();
	}
}
