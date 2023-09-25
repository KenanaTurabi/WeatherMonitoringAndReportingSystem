using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringAndReportingSystem.Bots
{
    internal class SnowBot
    {
        public int TemperatureThreshold { get; set; }
        public string Message { get; set; }

        public SnowBot(int temperatureThreshold, string message)
        {
            TemperatureThreshold = temperatureThreshold;
            Message = message;
        }
        public void Activate(int Temperature)
        {
            if (Temperature < TemperatureThreshold)
            {
                Console.WriteLine($"SnowBot activated!\r\nSnowBot: \"{Message}\"");

            }

        }
    }
}
