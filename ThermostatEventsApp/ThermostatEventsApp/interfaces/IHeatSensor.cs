namespace ThermostatEventsApp.interfaces;

public interface IHeatSensor
{
    event EventHandler<TemperatureEventsArgs> temperatureReachesEmergencyLevelEventHandler;
    event EventHandler<TemperatureEventsArgs> temperatureReachesWarningLevelEventHandler;
    event EventHandler<TemperatureEventsArgs> temperatureFallsBelowWarningLevelEventHandler;

    void RunHeatSensor();
}