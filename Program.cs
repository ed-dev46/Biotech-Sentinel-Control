using BiotechSentinelControl;

CrioContainer<Virus> virusContainer = new CrioContainer<Virus>();
TemperatureAlarm temperatureAlarm = new TemperatureAlarm();

Specimen specimen = new Virus("V1RU5123", "EBOLA", -15.4);

virusContainer.AddSpecimen((Virus)specimen);

specimen.OnTemperatureExceed += temperatureAlarm.NotifySecurity;

virusContainer.GetSpecimenByName("ebola").TemperatureC = 0;
