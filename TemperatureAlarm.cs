namespace BiotechSentinelControl;

public static class TemperatureAlarm
{

    private static string _logFilePath = "temperatureLog.txt";

    public static void NotifySecurity()
    {
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.WriteLine($"ALERT FOR SPECIMEN");
        Console.WriteLine($"TEMPERATURE EXCEED -10C");

        Console.ResetColor();
    }

    public static void TemperatureLog(Specimen specimen)
    {
        string logMessage = $"[{DateTime.Now}] SPECIMEN {specimen.Name} (ID: {specimen.Id}) EXCEEDS TEMPERATURE LIMIT: {specimen.TemperatureC}C";
        File.AppendAllText(_logFilePath, logMessage + Environment.NewLine);
        Console.WriteLine("Log Incident saved to temperatureLog.txt");
    }

}
