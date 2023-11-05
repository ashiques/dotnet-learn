namespace ThermostatEventsApp.interfaces;

public class TemperatureEventsArgs : EventArgs
{
    public double Temperature { get; set; }
    public DateTime CurrentDateTime { get; set; }
}