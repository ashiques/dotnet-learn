namespace ThermostatEventsApp.interfaces;

public class CoolingMechanism:ICoolingMechanism
{
    public void On()
    {
        Console.WriteLine();
        Console.WriteLine("Switching cooling mechanism on");
        Console.WriteLine();
    }

    public void Off()
    {
        Console.WriteLine();
        Console.WriteLine("Switching cooling mechanism off");
        Console.WriteLine();
    }
}