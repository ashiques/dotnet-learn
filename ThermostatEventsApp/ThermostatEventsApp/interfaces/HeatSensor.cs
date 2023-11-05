using System.ComponentModel;

namespace ThermostatEventsApp.interfaces;

public class HeatSensor:IHeatSensor
{
    private double _warningLevel = 0;
    private double _emergencyLevel = 0;
    private bool _hasReachedWarningTemperature = false;

    protected EventHandlerList _listEventDelegates = new EventHandlerList();

    private static readonly object _temperatureReachesWarningLevelKey = new object();

    public static readonly object _temperatureFallsBelowWarningLevelKey = new object();

    public static readonly object _temperatureReachesEmergencyLevelKey = new object();

    private double[] _temperatureData = null;

    public HeatSensor(double warningLevel, double emergencyLevel)
    {
        _warningLevel = warningLevel;
        _emergencyLevel = emergencyLevel;
    }

    private void seedData()
    {
        _temperatureData = new double[] { 16,17,16.5,18,19,22,34,26.75,28.7,27.6,26,24,22,45,68,86.45 };
    }

    private void MonitorTemperature()
    {
        foreach (var temperature in _temperatureData)
        {
            Console.ResetColor();
            Console.WriteLine(($"DateTime: {DateTime.Now}, Temperature:{temperature}"));
            if (temperature >= _emergencyLevel)
            {
                TemperatureEventsArgs e = new TemperatureEventsArgs
                {
                    Temperature = temperature,
                    CurrentDateTime = DateTime.Now
                };
                OnTemperatureReachesEmergencyLevel(e);

            }else if (temperature >= _warningLevel)
            {
                _hasReachedWarningTemperature = true;
                TemperatureEventsArgs e = new TemperatureEventsArgs
                {
                    Temperature = temperature,
                    CurrentDateTime = DateTime.Now
                };
                OnTemperatureFallsBelowWarningLevel(e);
            }
            else if(temperature< _warningLevel && _hasReachedWarningTemperature)
            {
                _hasReachedWarningTemperature = false;
                TemperatureEventsArgs e = new TemperatureEventsArgs
                {
                    Temperature = temperature,
                    CurrentDateTime = DateTime.Now
                };
                OnTemperatureFallsBelowWarningLevel(e);
                
            }
            Thread.Sleep(1000);
        }
    }

    protected void OnTemperatureReachesWarningLevel(TemperatureEventsArgs e)
    {
        EventHandler<TemperatureEventsArgs> handler =
            (EventHandler<TemperatureEventsArgs>)_listEventDelegates[_temperatureReachesWarningLevelKey];

        if (handler!=null)
        {
            handler(this, e);
        }
        
    }
    protected void OnTemperatureFallsBelowWarningLevel(TemperatureEventsArgs e)
    {
        EventHandler<TemperatureEventsArgs> handler =
            (EventHandler<TemperatureEventsArgs>)_listEventDelegates[_temperatureFallsBelowWarningLevelKey];

        if (handler!=null)
        {
            handler(this, e);
        }
        
    }
    protected void OnTemperatureReachesEmergencyLevel(TemperatureEventsArgs e)
    {
        EventHandler<TemperatureEventsArgs> handler =
            (EventHandler<TemperatureEventsArgs>)_listEventDelegates[_temperatureReachesEmergencyLevelKey];

        if (handler!=null)
        {
            handler(this, e);
        }
        
    }

    public event EventHandler<TemperatureEventsArgs>? temperatureReachesEmergencyLevelEventHandler
    {
        add => _listEventDelegates.AddHandler(_temperatureReachesEmergencyLevelKey,value);
        remove => _listEventDelegates.RemoveHandler(_temperatureReachesEmergencyLevelKey,value);
    }
    

    public event EventHandler<TemperatureEventsArgs>? temperatureReachesWarningLevelEventHandler
    {
        add =>_listEventDelegates.AddHandler(_temperatureReachesWarningLevelKey,value); 
        remove => _listEventDelegates.RemoveHandler(_temperatureReachesWarningLevelKey,value);
    }

    event EventHandler<TemperatureEventsArgs>? IHeatSensor.temperatureFallsBelowWarningLevelEventHandler
    {
        add => _listEventDelegates.AddHandler(_temperatureFallsBelowWarningLevelKey,value);
        remove => _listEventDelegates.RemoveHandler(_temperatureFallsBelowWarningLevelKey,value);
    }


    public void RunHeatSensor()
    {
        Console.WriteLine("Heat Sensor is Running...");
        MonitorTemperature();
    }
    
}