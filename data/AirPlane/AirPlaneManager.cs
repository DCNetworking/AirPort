using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirPortSchdeuler.data;

public class AirPlaneManager
{
	private readonly List<AirPlane> AirPlaneList;
	readonly static Lazy<AirPlaneManager> airPlaneManager = new(() => new AirPlaneManager());
	public static AirPlaneManager Init
	{
		get => airPlaneManager.Value;
	}
	public List<AirPlane> GetAll()
	{
		return AirPlaneList;
	}
	private AirPlaneManager()
	{
		AirPlaneList = new()
		{
			new AirPlane
			{
				Type = AirPlaneType.AirbusA320,
				Name = "Airbus A320",
				Producer = "Airbus",
				MaxSpeed = 514,
				FuelWeightKgUsage1H = 2_800,
				FuelWeightKgTankCapacity = 23_860,
				PassengersCapacity = 180
			},
			new AirPlane
			{
				Type = AirPlaneType.AirbusA330,
				Name = "Airbus A330",
				Producer = "Airbus",
				MaxSpeed = 1004,
				FuelWeightKgUsage1H = 8_000,
				FuelWeightKgTankCapacity = 97_530,
				PassengersCapacity = 300,
			},
			new AirPlane
			{
				Type = AirPlaneType.AirbusA350,
				Name = "Airbus A350",
				Producer = "Airbus",
				MaxSpeed = 1049,
				FuelWeightKgUsage1H = 6_500,
				FuelWeightKgTankCapacity = 138_000,
				PassengersCapacity = 440,
			},
			new AirPlane
			{
				Type = AirPlaneType.AirbusA380,
				Name = "Airbus A380",
				Producer = "Airbus",
				MaxSpeed = 1020,
				FuelWeightKgUsage1H = 14_000,
				FuelWeightKgTankCapacity = 320_000,
				PassengersCapacity = 853,
			},
			new AirPlane
			{
				Type = AirPlaneType.Boeing737,
				Name = "Boeing 737",
				Producer = "Boeing",
				MaxSpeed = 952,
				FuelWeightKgUsage1H = 2_800,
				FuelWeightKgTankCapacity = 22_830,
				PassengersCapacity = 215,
			},
			new AirPlane
			{
				Type = AirPlaneType.Boeing747,
				Name = "Boeing 747",
				Producer = "Boeing",
				MaxSpeed = 1047,
				FuelWeightKgUsage1H = 13_000,
				FuelWeightKgTankCapacity = 216_840,
				PassengersCapacity = 660,
			},
			new AirPlane
			{
				Type = AirPlaneType.Boeing757,
				Name = "Boeing 757",
				Producer = "Boeing",
				MaxSpeed = 952,
				FuelWeightKgUsage1H = 4_000,
				FuelWeightKgTankCapacity = 43_490,
				PassengersCapacity = 239,
			},
			new AirPlane
			{
				Type = AirPlaneType.Boeing767,
				Name = "Boeing 767",
				Producer = "Boeing",
				MaxSpeed = 871,
				FuelWeightKgUsage1H = 5_000,
				FuelWeightKgTankCapacity = 91_760,
				PassengersCapacity = 375,
			},
			new AirPlane
			{
				Type = AirPlaneType.Boeing777,
				Name = "Boeing 777",
				Producer = "Boeing",
				MaxSpeed = 950,
				FuelWeightKgUsage1H = 10_000,
				FuelWeightKgTankCapacity = 171_170,
				PassengersCapacity = 396
			},
			new AirPlane
			{
				Type = AirPlaneType.EmbraerE190,
				Name = "Embraer E190",
				Producer = "Embraer",
				MaxSpeed = 863,
				FuelWeightKgUsage1H = 1_800,
				FuelWeightKgTankCapacity = 11_340,
				PassengersCapacity = 114,
			},
			new AirPlane
			{
				Type = AirPlaneType.BombardierCRJ900,
				Name = "Bombardier CRJ900",
				Producer = "Bombardier",
				MaxSpeed = 828,
				FuelWeightKgUsage1H = 2_500,
				FuelWeightKgTankCapacity = 18_550,
				PassengersCapacity = 90,
			},
			new AirPlane
			{
				Type = AirPlaneType.ATR72,
				Name = "ATR 72",
				Producer = "ATR",
				MaxSpeed = 511,
				FuelWeightKgUsage1H = 1_200,
				FuelWeightKgTankCapacity = 7_400,
				PassengersCapacity = 78,
			},
			new AirPlane
			{
				Type = AirPlaneType.CessnaCitation,
				Name = "Cessna Citation",
				Producer = "Cessna",
				MaxSpeed = 882,
				FuelWeightKgUsage1H = 500,
				FuelWeightKgTankCapacity = 2_500,
				PassengersCapacity = 12
			},
			new AirPlane
			{
				Type = AirPlaneType.DassaultFalcon,
				Name = "Dassault Falcon",
				Producer = "Dassault",
				MaxSpeed = 892,
				FuelWeightKgUsage1H = 2_000,
				FuelWeightKgTankCapacity = 13_000,
				PassengersCapacity = 20
			},
			new AirPlane
			{
				Type = AirPlaneType.GulfstreamG650,
				Name = "Gulfstream G650",
				Producer = "Gulfstream",
				MaxSpeed = 1040,
				FuelWeightKgUsage1H = 4_500,
				FuelWeightKgTankCapacity = 35_000,
				PassengersCapacity = 18
			},
			new AirPlane
			{
				Type = AirPlaneType.McDonnellDouglasMD80,
				Name = "McDonnell Douglas MD-80",
				Producer = "McDonnell Douglas",
				MaxSpeed = 982,
				FuelWeightKgUsage1H = 4_000,
				FuelWeightKgTankCapacity = 26_000,
				PassengersCapacity = 172
			},
			new AirPlane
			{
				Type = AirPlaneType.SukhoiSuperjet,
				Name = "Sukhoi Superjet",
				Producer = "Sukhoi",
				MaxSpeed = 952,
				FuelWeightKgUsage1H = 2_200,
				FuelWeightKgTankCapacity = 15_000,
				PassengersCapacity = 108
			},
			new AirPlane
			{
				Type = AirPlaneType.AntonovAn124,
				Name = "Antonov An-124",
				Producer = "Antonov",
				MaxSpeed = 983,
				FuelWeightKgUsage1H = 12_000,
				FuelWeightKgTankCapacity = 126_000,
				PassengersCapacity = 0
			},
			new AirPlane
			{
				Type = AirPlaneType.BeechcraftKingAir,
				Name = "Beechcraft King Air",
				Producer = "Beechcraft",
				MaxSpeed = 578,
				FuelWeightKgUsage1H = 700,
				FuelWeightKgTankCapacity = 2_400,
				PassengersCapacity = 11
			},
			new AirPlane
			{
				Type = AirPlaneType.CessnaCaravan,
				Name = "Cessna Caravan",
				Producer = "Cessna",
				MaxSpeed = 295,
				FuelWeightKgUsage1H = 450,
				FuelWeightKgTankCapacity = 1_500,
				PassengersCapacity = 14
			},
			new AirPlane
			{
				Type = AirPlaneType.PiperCherokee,
				Name = "Piper Cherokee",
				Producer = "Piper",
				MaxSpeed = 237,
				FuelWeightKgUsage1H = 300,
				FuelWeightKgTankCapacity = 900,
				PassengersCapacity = 4
			},
			new AirPlane
			{
				Type = AirPlaneType.BeechcraftBaron,
				Name = "Beechcraft Baron",
				Producer = "Beechcraft",
				MaxSpeed = 374,
				FuelWeightKgUsage1H = 400,
				FuelWeightKgTankCapacity = 1_300,
				PassengersCapacity = 6
			},
			new AirPlane
			{
				Type = AirPlaneType.BeechcraftBonanza,
				Name = "Beechcraft Bonanza",
				Producer = "Beechcraft",
				MaxSpeed = 326,
				FuelWeightKgUsage1H = 350,
				FuelWeightKgTankCapacity = 1_100,
				PassengersCapacity = 6
			},
			new AirPlane
			{
				Type = AirPlaneType.CessnaCitationX,
				Name = "Cessna Citation X",
				Producer = "Cessna",
				MaxSpeed = 833,
				FuelWeightKgUsage1H = 1_800,
				FuelWeightKgTankCapacity = 9_100,
				PassengersCapacity = 12
			},
			new AirPlane
			{
				Type = AirPlaneType.GulfstreamG550,
				Name = "Gulfstream G550",
				Producer = "Gulfstream",
				MaxSpeed = 903,
				FuelWeightKgUsage1H = 3_500,
				FuelWeightKgTankCapacity = 28_000,
				PassengersCapacity = 18
			},
			new AirPlane
			{
				Type = AirPlaneType.BombardierChallenger,
				Name = "Bombardier Challenger",
				Producer = "Bombardier",
				MaxSpeed = 855,
				FuelWeightKgUsage1H = 2_800,
				FuelWeightKgTankCapacity = 17_000,
				PassengersCapacity = 19
			},
		};
	}
}
