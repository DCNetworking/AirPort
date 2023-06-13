using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirPortSchdeuler.AirPort;
public class AirPortManager
{
	private readonly List<AirPort> AirPortsList;
	readonly static Lazy<AirPortManager> airPortManager = new(() => new AirPortManager());
	public static AirPortManager Init
	{
		get => airPortManager.Value;
	}

	public List<AirPort> GetAirPorts()
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
					TimeZone = "America/New_York"
				},
				new AirPort
				{
					AirPortCode = AirPortCode.PEK,
					City = "Beijing",
					Country = "China",
					Name = "Beijing Capital International Airport",
					TimeZone = "Asia/Shanghai"
				},
				new AirPort
				{
					AirPortCode = AirPortCode.FRA,
					City = "Frankfurt",
					Country = "Germany",
					Name = "Frankfurt Airport",
					TimeZone = "Europe/Berlin"
				},
				new AirPort
				{
					AirPortCode = AirPortCode.CAN,
					City = "Guangzhou",
					Country = "China",
					Name = "Guangzhou Baiyun International Airport",
					TimeZone = "Asia/Shanghai"
				},
				new AirPort
				{
					AirPortCode = AirPortCode.BKK,
					City = "Bangkok",
					Country = "Thailand",
					Name = "Suvarnabhumi Airport",
					TimeZone = "Asia/Bangkok"
				},
				new AirPort
				{
					AirPortCode = AirPortCode.SVO,
					City = "Moscow",
					Country = "Russia",
					Name = "Sheremetyevo International Airport",
					TimeZone = "Europe/Moscow"
				},
				new AirPort
				{
					AirPortCode = AirPortCode.CDG,
					City = "Paris",
					Country = "France",
					Name = "Paris Charles de Gaulle Airport",
					TimeZone = "Europe/Paris"
				},
				new AirPort
				{
					AirPortCode = AirPortCode.MAD,
					City = "Madrid",
					Country = "Spain",
					Name = "Adolfo Suárez Madrid–Barajas Airport",
					TimeZone = "Europe/Madrid"
				},
				new AirPort
				{
					AirPortCode = AirPortCode.DEL,
					City = "Delhi",
					Country = "India",
					Name = "Indira Gandhi International Airport",
					TimeZone = "Asia/Kolkata"
				},
				new AirPort
				{
					AirPortCode = AirPortCode.ORD,
					City = "Chicago",
					Country = "United States",
					Name = "O'Hare International Airport",
					TimeZone = "America/Chicago"
				},
				new AirPort
				{
					AirPortCode = AirPortCode.GRU,
					City = "Sao Paulo",
					Country = "Brazil",
					Name = "Sao Paulo-Guarulhos International Airport",
					TimeZone = "America/Sao_Paulo"
				},
				new AirPort
				{
					AirPortCode = AirPortCode.LAX,
					City = "Los Angeles",
					Country = "United States",
					Name = "Los Angeles International Airport",
					TimeZone = "America/Los_Angeles"
				},
				new AirPort
				{
					AirPortCode = AirPortCode.HKG,
					City = "Hong Kong",
					Country = "Hong Kong",
					Name = "Hong Kong International Airport",
					TimeZone = "Asia/Hong_Kong"
				},
				new AirPort
				{
					AirPortCode = AirPortCode.IST,
					City = "Istanbul",
					Country = "Turkey",
					Name = "Istanbul Airport",
					TimeZone = "Europe/Istanbul"
				},
				new AirPort
				{
					AirPortCode = AirPortCode.LHR,
					City = "London",
					Country = "United Kingdom",
					Name = "Heathrow Airport",
					TimeZone = "Europe/London"
				},
				new AirPort
				{
					AirPortCode = AirPortCode.MEX,
					City = "Mexico City",
					Country = "Mexico",
					Name = "Benito Juárez International Airport",
					TimeZone = "America/Mexico_City"
				},
				new AirPort
				{
					AirPortCode = AirPortCode.MUC,
					City = "Munich",
					Country = "Germany",
					Name = "Munich Airport",
					TimeZone = "Europe/Berlin"
				},
				new AirPort
				{
					AirPortCode = AirPortCode.SYD,
					City = "Sydney",
					Country = "Australia",
					Name = "Sydney Airport",
					TimeZone = "Australia/Sydney"
				}
			};
	}
}

