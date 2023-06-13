using AirPortSchdeuler.AirPlane;
using AirPortSchdeuler.AirPort;

AirPortManager apm = AirPortManager.Init;
var airPorts = apm.GetAirPorts();
foreach (AirPort airPort in airPorts)
{
    System.Console.WriteLine(airPort.ToString());
}
