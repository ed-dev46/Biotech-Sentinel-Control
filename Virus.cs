namespace BiotechSentinelControl;

public class Virus : Specimen, IRisk
{
    public Virus(string id, string name, double temperatureC) : base(id, name, temperatureC)
    {
    }

    public RiskEnum RiskLevel => RiskEnum.DANGEROUS;

    public void AlertProtocol()
    {
        var consoleBackgroundColor = Console.BackgroundColor;
        var consoleTxtColor = Console.ForegroundColor;

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"ALERT! VIRUS {Name} DETECTED");
        Thread.Sleep(2000);
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.WriteLine("CONTAINMENT PROTOCOLS ACTIVATED");
        Thread.Sleep(2000);
        Console.WriteLine("ISOLATING THE AFFECTED AREA...");
        Thread.Sleep(2000);
        Console.WriteLine("DECONTAMINATION IN PROGRESS...");
        Thread.Sleep(2000);
        Console.WriteLine("ASSISTED IMMUNE RESPONSE ACTIVATION...");
        Thread.Sleep(2000);
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("THREAT NEUTRALIZED! QUARANTINE BEING LIFTED...");
        
        Console.ForegroundColor = consoleTxtColor;
        Console.BackgroundColor = consoleBackgroundColor;
    }
}
