namespace BiotechSentinelControl;

public static class TemperatureAlarm
{

    public static void NotifySecurity()
    {
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.WriteLine($"ALERT FOR SPECIMEN");
        Console.WriteLine($"TEMPERATURE EXCEED -10C");

        Console.ResetColor();
    }

}
