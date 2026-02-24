namespace BiotechSentinelControl;

public delegate void TemperatureHandler(string name, double temperatureC);
public abstract class Specimen
{

    public event TemperatureHandler OnTemperatureExceed;

    public string Id { get; }
    public string Name { get; set; }
    private double _temperatureC;
    public double TemperatureC {
        get => _temperatureC;
        set
        {
            _temperatureC = TemperatureC;
            if (_temperatureC > -10)
            {
                OnTemperatureExceed?.Invoke(Name, _temperatureC);
            }
        }
    }
    
    public Specimen(string id, string name, double temperatureC)
    {
        Id = id;
        Name = name;
        TemperatureC = temperatureC;
    }

    public override string ToString()
    {
        return $"Id: {Id}\nName: {Name}\nTemperature: {TemperatureC}C";
    }
}
