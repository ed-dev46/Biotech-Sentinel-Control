using BiotechSentinelControl;

CrioContainer<Virus> virusContainer = new CrioContainer<Virus>();
TemperatureAlarm temperatureAlarm = new TemperatureAlarm();

Specimen specimen = new Virus("V1RU5123", "EBOLA", -15.4);


specimen.OnTemperatureExceed += temperatureAlarm.NotifySecurity;
specimen.OnTemperatureExceed += virusContainer.CoolingDown;


virusContainer.AddSpecimen((Virus)specimen);
specimen.TemperatureC = 0;