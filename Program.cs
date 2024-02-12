using SaballutsWeatherLoader.Services;
using Microsoft.Extensions.Configuration;

IConfigurationRoot configuration = new ConfigurationBuilder()
.SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
.AddJsonFile("appsettings.json")
.Build();

FileReader sourceReader = new(configuration["CsvFilePath"]!);
var csvWeatherRecords = sourceReader.Read();
foreach (var record in csvWeatherRecords)
{
    System.Console.WriteLine($"Date: {record.Date} - Time: {record.Time}");
}
