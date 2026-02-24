using System.Diagnostics;

namespace BiotechSentinelControl;

public class TemperatureAlarm
{

    public void NotifySecurity(string name, double temperatureC)
    {
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.WriteLine($"ALERT FOR SPECIMEN {name.ToUpper()}");
        Console.WriteLine($"TEMPERATURE EXCEED -10C - CURRENT: {temperatureC}C");

        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.DarkCyan;

        Console.WriteLine("ACTIVATING COOLING DOWN SYSTEM...");

        Console.ResetColor();
    }

}
