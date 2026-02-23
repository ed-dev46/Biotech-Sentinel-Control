namespace BiotechSentinelControl;

public delegate void CoolHandler();
public class TemperatureAlarm
{
    public event CoolHandler OnAlarmTrigger;

    public void NotifySecurity()
    {
        Console.WriteLine("ALERT! TEMPERATURE EXCEED\nTURNING ON COOLING SYSTEM...");
        OnAlarmTrigger?.Invoke();
    }

}
