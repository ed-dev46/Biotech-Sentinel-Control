namespace BiotechSentinelControl;

public delegate void TemperatureHandler(Specimen specimen);
public delegate void SecurityAlertHandler();
public abstract class Specimen
{

    public event TemperatureHandler OnTemperatureExceed;
    public static event SecurityAlertHandler OnSecurityAlert;

    public string Id { get; }
    public string Name { get; set; }
    private double _temperatureC;
    public double TemperatureC {
        get => _temperatureC;
        set
        {
            _temperatureC = value;
            if (_temperatureC > -10.0)
            {
                OnTemperatureExceed?.Invoke(this);
                OnSecurityAlert?.Invoke();
            }
        }
    }
    
    public Specimen(string id, string name, double temperatureC)
    {
        Id = id;
        Name = name;
        if (temperatureC > -10.0)
        {
            throw new ArgumentException("THE TEMPERATURE CAN NOT EXCEED -10.0C");
        } else
        {
            _temperatureC = temperatureC;
        }
    }

    public override string ToString()
    {
        return $"Id: {Id}\nName: {Name}\nTemperature: {TemperatureC}C";
    }
}
