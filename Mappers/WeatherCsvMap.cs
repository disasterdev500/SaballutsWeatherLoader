using SaballutsWeatherLoader.Dtos;
using CsvHelper.Configuration;

namespace SaballutsWeatherLoader.Mappers
{   
    public sealed class WeatherCsvMap : ClassMap<CsvWeatherRecord>
    {
        public WeatherCsvMap(){
            Map(m => m.Date).Name("Fecha");
            Map(m => m.Time).Name("Hora");
            Map(m => m.IndoorTemperatureC).Name("Temperatura interior");
            Map(m => m.IndoorHumidityPct).Name("Humedad interior(%)");
            Map(m => m.OutdoorTemperatureC).Name("Temperatura exterior");
            Map(m => m.OutdoorHumidityPct).Name("Humedad exterior(%)");
            Map(m => m.DewPointC).Name("Punto de rocío");
            Map(m => m.ThermalSensationC).Name("Sensación Térmica");
            Map(m => m.WindSpeedKmH).Name("Viento(km/h)");
            Map(m => m.GustSpeedKmH).Name("Racha(km/h)");
            Map(m => m.WindDirection).Name("Dirección del viento");
            Map(m => m.AbsolutePressureHpa).Name("Presión absoluta(hpa)");
            Map(m => m.RelativePressureHpa).Name("Presión relativa(hpa)");
            Map(m => m.SolarRadiationWm2).Name("Radiación Solar(w/m2)");
            Map(m => m.UVI).Name("UVI");
            Map(m => m.RainPerHourMm).Name("Lluvia por hora(mm)");
            Map(m => m.RainEpisodeMm).Name("Episodio de lluvia(mm)");
            Map(m => m.RainPerDayMm).Name("Lluvia por día(mm)");
            Map(m => m.RainPerWeekMm).Name("Lluvia semanal(mm)");
            Map(m => m.RainPerMonthMm).Name("Lluvia mensual(mm)");
            Map(m => m.RainPerYearMm).Name("Lluvia anual(mm)");
        }
    }
}