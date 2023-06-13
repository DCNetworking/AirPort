using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirPort.AirPlane;

public class AirPlaneManager
{
    private readonly List<AirPlane> AirPlaneList;
    readonly Lazy<AirPlaneManager> airPlaneManager = new(() => new AirPlaneManager());
    public AirPlaneManager Init
    {
        get => airPlaneManager.Value;
    }

    private AirPlaneManager()
    {
        AirPlaneList = new()
            {
                new AirPlane
                {
                    Type = AirPlaneType.AirbusA320,
                    Name = "Airbus A320",
                    Producer = "Airbus"
                },
                new AirPlane
                {
                    Type = AirPlaneType.AirbusA330,
                    Name = "Airbus A330",
                    Producer = "Airbus"
                },
                new AirPlane
                {
                    Type = AirPlaneType.AirbusA350,
                    Name = "Airbus A350",
                    Producer = "Airbus"
                },
                new AirPlane
                {
                    Type = AirPlaneType.AirbusA380,
                    Name = "Airbus A380",
                    Producer = "Airbus"
                },
                new AirPlane
                {
                    Type = AirPlaneType.Boeing737,
                    Name = "Boeing 737",
                    Producer = "Boeing"
                },
                new AirPlane
                {
                    Type = AirPlaneType.Boeing747,
                    Name = "Boeing 747",
                    Producer = "Boeing"
                },
                new AirPlane
                {
                    Type = AirPlaneType.Boeing757,
                    Name = "Boeing 757",
                    Producer = "Boeing"
                },
                new AirPlane
                {
                    Type = AirPlaneType.Boeing767,
                    Name = "Boeing 767",
                    Producer = "Boeing"
                },
                new AirPlane
                {
                    Type = AirPlaneType.Boeing777,
                    Name = "Boeing 777",
                    Producer = "Boeing"
                },
                new AirPlane
                {
                    Type = AirPlaneType.Boeing787,
                    Name = "Boeing 787",
                    Producer = "Boeing"
                },
                new AirPlane
                {
                    Type = AirPlaneType.EmbraerE190,
                    Name = "Embraer E190",
                    Producer = "Embraer"
                },
                new AirPlane
                {
                    Type = AirPlaneType.BombardierCRJ900,
                    Name = "Bombardier CRJ900",
                    Producer = "Bombardier"
                },
                new AirPlane
                {
                    Type = AirPlaneType.ATR72,
                    Name = "ATR 72",
                    Producer = "ATR"
                },
                new AirPlane
                {
                    Type = AirPlaneType.CessnaCitation,
                    Name = "Cessna Citation",
                    Producer = "Cessna"
                },
                new AirPlane
                {
                    Type = AirPlaneType.DassaultFalcon,
                    Name = "Dassault Falcon",
                    Producer = "Dassault"
                },
                new AirPlane
                {
                    Type = AirPlaneType.GulfstreamG650,
                    Name = "Gulfstream G650",
                    Producer = "Gulfstream"
                },
                new AirPlane
                {
                    Type = AirPlaneType.McDonnellDouglasMD80,
                    Name = "McDonnell Douglas MD-80",
                    Producer = "McDonnell Douglas"
                },
                new AirPlane
                {
                    Type = AirPlaneType.SukhoiSuperjet,
                    Name = "Sukhoi Superjet",
                    Producer = "Sukhoi"
                },
                new AirPlane
                {
                    Type = AirPlaneType.AntonovAn124,
                    Name = "Antonov An-124",
                    Producer = "Antonov"
                },
                new AirPlane
                {
                    Type = AirPlaneType.BeechcraftKingAir,
                    Name = "Beechcraft King Air",
                    Producer = "Beechcraft"
                },
                new AirPlane
                {
                    Type = AirPlaneType.CessnaCaravan,
                    Name = "Cessna Caravan",
                    Producer = "Cessna"
                },
                new AirPlane
                {
                    Type = AirPlaneType.PiperCherokee,
                    Name = "Piper Cherokee",
                    Producer = "Piper"
                },
                new AirPlane
                {
                    Type = AirPlaneType.BeechcraftBaron,
                    Name = "Beechcraft Baron",
                    Producer = "Beechcraft"
                },
                new AirPlane
                {
                    Type = AirPlaneType.BeechcraftBonanza,
                    Name = "Beechcraft Bonanza",
                    Producer = "Beechcraft"
                },
                new AirPlane
                {
                    Type = AirPlaneType.CessnaCitationX,
                    Name = "Cessna Citation X",
                    Producer = "Cessna"
                },
                new AirPlane
                {
                    Type = AirPlaneType.GulfstreamG550,
                    Name = "Gulfstream G550",
                    Producer = "Gulfstream"
                },
                new AirPlane
                {
                    Type = AirPlaneType.BombardierChallenger,
                    Name = "Bombardier Challenger",
                    Producer = "Bombardier"
                },
            };
    }
}
