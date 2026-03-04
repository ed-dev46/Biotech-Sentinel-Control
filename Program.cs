using BiotechSentinelControl;

CrioContainer<Virus> virusContainer = new CrioContainer<Virus>();
Specimen.OnSecurityAlert += TemperatureAlarm.NotifySecurity;

try
{
    Specimen specimen = new Virus("V1RU5123", "EBOLA", -13.0);
    virusContainer.AddSpecimen((Virus)specimen);
    specimen.TemperatureC = 0;
} catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
} finally
{
    Console.WriteLine(virusContainer);
    Console.WriteLine("OPERATION FINISHED");
}


