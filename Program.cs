using BiotechSentinelControl;

CrioContainer<Virus> virusContainer = new CrioContainer<Virus>();

Specimen specimen = new Virus("V1RU5123", "EBOLA", -15.4);

virusContainer.AddSpecimen((Virus)specimen);

try
{
    var virus = virusContainer.GetSpecimenByName("Ebola");
    Console.WriteLine(virus);
} catch (Exception e)
{
    Console.WriteLine(e.Message);
}
