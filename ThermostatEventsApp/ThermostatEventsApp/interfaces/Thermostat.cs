namespace ThermostatEventsApp.interfaces;

public class Thermostat:IThermostat
{
    private ICoolingMechanism _coolingMechanism = null;
    private IHeatSensor _heatSensor = null;
    private IDevice _device = null;

    private const double WarningLevel = 27;
    private const double EmergencyLevel = 75;

    public Thermostat(ICoolingMechanism coolingMechanism, IHeatSensor heatSensor, IDevice device)
    {
        _coolingMechanism = coolingMechanism;
        _heatSensor = heatSensor;
        _device = device;
    }

    private void WireUpEventsToEventHandlers()
    {
        _heatSensor.temperatureReachesWarningLevelEventHandler += HeatSensorOnTemperatureReachesWarningLevelEventHandler;
        _heatSensor.temperatureReachesEmergencyLevelEventHandler += HeatSensorOnTemperatureReachesEmergencyLevelEventHandler;
        _heatSensor.temperatureFallsBelowWarningLevelEventHandler += HeatSensorOnTemperatureFallsBelowWarningLevelEventHandler;
        
    }

    private void HeatSensorOnTemperatureFallsBelowWarningLevelEventHandler(object? sender, TemperatureEventsArgs e)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine();
        Console.WriteLine($"Information Alert!! Temperature falls below warning level (Warning level is between {WarningLevel} and {EmergencyLevel}");
        _coolingMechanism.Off();
        Console.ResetColor();
    }

    private void HeatSensorOnTemperatureReachesEmergencyLevelEventHandler(object? sender, TemperatureEventsArgs e)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine();
        Console.WriteLine($"Emergency Alert!! (Emergency level is {EmergencyLevel} and above.");
        _device.HandleEmergency();
        Console.ResetColor();
    }

    private void HeatSensorOnTemperatureReachesWarningLevelEventHandler(object? sender, TemperatureEventsArgs e)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine();
        Console.WriteLine($"Warning Alert!! (Warning level is between {WarningLevel} and {EmergencyLevel}");
        _coolingMechanism.On();
        Console.ResetColor();
        
    }

    public void RunThermostat()
    {
        Console.WriteLine("Thermostat is running...");
        WireUpEventsToEventHandlers();
        _heatSensor.RunHeatSensor();
    }
}