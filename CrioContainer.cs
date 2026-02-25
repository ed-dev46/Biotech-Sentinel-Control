using System.Linq;

namespace BiotechSentinelControl;

public class CrioContainer<T> where T : Specimen
{
    private List<T> _crioContainer = new List<T>();

    public void AddSpecimen(T specimen)
    {
        if (specimen.TemperatureC > 0)
        {
            throw new ArgumentException("THE TEMPERATURE CAN NOT EXCEED 0C");
        } else
        {
            specimen.Name = specimen.Name.ToLower();
            _crioContainer.Add(specimen);
        }
    }

    public T GetSpecimenByName(string name)
    {
        var specimen = _crioContainer.FirstOrDefault(x => x.Name.ToLower() == name.ToLower());

        if (specimen == null) throw new ArgumentException();

        return specimen;
    }

    public void CoolingDown(Specimen specimen)
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine($"COOLING DOWN SPECIMEN {specimen.Name}");

        specimen.TemperatureC = -20.0;

        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"THE TEMPERATURE OF SPECIMEN {specimen.Name.ToUpper()} WAS STABILIZED");
        Console.WriteLine($"ACTUAL: {specimen.TemperatureC}C");
        
        Console.ResetColor();
    }
}
