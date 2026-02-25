namespace BiotechSentinelControl;

public class TemperatureAlarm
{

    public void NotifySecurity(Specimen specimen)
    {
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.WriteLine($"ALERT FOR SPECIMEN {specimen.Name.ToUpper()}");
        Console.WriteLine($"TEMPERATURE EXCEED -10C - CURRENT: {specimen.TemperatureC}C");

        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.DarkCyan;

        Console.WriteLine("ACTIVATING COOLING DOWN SYSTEM...");

        Console.ResetColor();
    }

}
