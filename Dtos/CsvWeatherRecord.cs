
namespace SaballutsWeatherLoader.Dtos
{
    public class CsvWeatherRecord
    {
        public string? Date { get; set; }
        public string? Time { get; set; }
        public double IndoorTemperatureC { get; set; }
        public double IndoorHumidityPct { get; set; }
        public double OutdoorTemperatureC { get; set; }
        public double OutdoorHumidityPct { get; set; }
        public double DewPointC { get; set; }
        public double ThermalSensationC { get; set; }
        public double WindSpeedKmH { get; set; }
        public double GustSpeedKmH { get; set; }
        public double WindDirection { get; set; }
        public string? AbsolutePressureHpa { get; set; }
        public string? RelativePressureHpa { get; set; }
        public double SolarRadiationWm2 { get; set; }
        public double UVI { get; set; }
        public double RainPerHourMm { get; set; }
        public double RainEpisodeMm { get; set; }
        public double RainPerDayMm { get; set; }
        public double RainPerWeekMm { get; set; }
        public double RainPerMonthMm { get; set; }
        public double RainPerYearMm { get; set; }
    }
}