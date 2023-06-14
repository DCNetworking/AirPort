using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirPortSchdeuler.data
{
	public class Repository : IRepository
	{
		private APContext _ctx;

		public Repository()
		{
			System.Console.WriteLine($"Init from {this.GetType().Name}");
			_ctx = new APContext();
		}

		public AirPort GetAirport(AirPortCode airportCode)
		{
			return _ctx.airPortManager
			.GetAll()
			.FirstOrDefault(ap => ap.AirPortCode == airportCode, new AirPort());
		}
		public List<AirPort> GetAirport(string fragment)
		{
			fragment = fragment.ToLower();
			return _ctx.airPortManager
			.GetAll()
			.Where(ap => ap.ToString().ToLower().Contains(fragment))
			.ToList();
		}
	}
}
