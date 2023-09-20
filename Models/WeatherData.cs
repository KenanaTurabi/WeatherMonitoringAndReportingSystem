using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringAndReportingSystem.Models
{
    internal class WeatherData
    {
        public int Temperature { get; set; }
        public int Humidity { get; set; }
        public string Location  { get; set; }

        public string toString()
        {
            return $"Location: {Location}\nTemperature: {Temperature}\nHumidity: {Humidity}\n";
        }
    }
}
