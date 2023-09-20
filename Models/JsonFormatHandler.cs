using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace WeatherMonitoringAndReportingSystem.Models
{
    internal class JsonFormatHandler
    {
        public WeatherData ParseJson(string jsonData)
        {
            try
            {
                WeatherData weatherData = JsonConvert.DeserializeObject<WeatherData>(jsonData);
                return weatherData;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error parsing JSON data: {ex.Message}");
                return null;
            }
        }
    }





}

