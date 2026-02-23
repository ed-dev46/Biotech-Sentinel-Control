namespace BiotechSentinelControl;

public class Reagent : Specimen, IRisk
{
    public Reagent(string id, string name, double temperatureC) : base(id, name, temperatureC)
    {
    }

    public RiskEnum RiskLevel => RiskEnum.CAUTION;

    public void AlertProtocol()
    {
        var consoleBackgroundColor = Console.BackgroundColor;
        var consoleTxtColor = Console.ForegroundColor;

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"ALERT! REAGENT {Name} DETECTED");
        Thread.Sleep(2000);
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.WriteLine("CONTAINMENT PROTOCOLS ACTIVATED");
        Thread.Sleep(2000);
        Console.WriteLine("ISOLATING THE AFFECTED AREA...");
        Thread.Sleep(2000);
        Console.WriteLine("ALERTING DAMAGE CONTROL AND REGISTERING THE INCIDENT...");
        Thread.Sleep(2000);
        Console.WriteLine("ACTIVATION OF CONTROLLED INCINERATION SYSTEM...");
        Thread.Sleep(2000);
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("THREAT NEUTRALIZED! QUARANTINE BEING LIFTED...");
        
        Console.ForegroundColor = consoleTxtColor;
        Console.BackgroundColor = consoleBackgroundColor;
    }
}
