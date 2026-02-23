using System.Linq;

namespace BiotechSentinelControl;

public class CrioContainer<T> where T : Specimen
{
    private List<T> crioContainer = new List<T>();

    public void AddSpecimen(T specimen)
    {
        if (specimen.TemperatureC > 0)
        {
            throw new ArgumentException("THE TEMPERATURE CAN NOT EXCEED 0C");
        } else
        {
            specimen.Name = specimen.Name.ToLower();
            crioContainer.Add(specimen);
        }
    }

    public T GetSpecimenByName(string name)
    {
        var specimen = crioContainer.FirstOrDefault(x => x.Name.ToLower() == name.ToLower());

        if (specimen == null) throw new ArgumentException();

        return specimen;
    }

    private void CoolSpecimen(T specimen)
    {
        specimen.TemperatureC = -15;
    }
}
