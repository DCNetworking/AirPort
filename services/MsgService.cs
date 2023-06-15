using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirPortSchdeuler.services
{
	public class MsgService
	{
		public static string FlightCancelledMsg(string FlightId)
		{
			return $"Flight Id: {FlightId} is already Cancelled";
		}
		public static string FlightArrivalTimeChange(string FlightId, DateTime arrivalDateTime)
		{
			return $"Flight Id: {FlightId} | NEW Arrival DateTime : {arrivalDateTime:yyyy-MM-d HH:mm}";
		}
		public static string FlightStatusMsg(string FlightId, FlightStatusType FlightStatusType)
		{
			return $"Flight Id: {FlightId} | NEW Status : {FlightStatusType}";
		}
		public static string PlaneNotFoundForFlight(decimal DistanceKM)
		{
			return $"There is no Plane on current List which passing distance of {DistanceKM} km reqirements";
		}
	}
}