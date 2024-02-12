using CsvHelper;
using System.Globalization;
using SaballutsWeatherLoader.Dtos;
using SaballutsWeatherLoader.Mappers;
using CsvHelper.Configuration;

namespace SaballutsWeatherLoader.Services
{
    public class FileReader(string filePath)
    {
        private readonly string _filePath = filePath;

        public IList<CsvWeatherRecord> Read(){
            if (string.IsNullOrEmpty(_filePath))
            {
                throw new Exception("File path is null or empty");
            }

            List<CsvWeatherRecord> records;

            try {
                var csvConfiguration = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    Delimiter = ";"
                };
                using (var reader = new StreamReader(_filePath))
                using (var csv = new CsvReader(reader, csvConfiguration))
                {
                    csv.Context.RegisterClassMap<WeatherCsvMap>();
                    records = csv.GetRecords<CsvWeatherRecord>().ToList();
                }
            } catch (Exception e){
                throw new Exception("Unexpected error while reading csv file", e);
            }

            return records;
        }
    }
}