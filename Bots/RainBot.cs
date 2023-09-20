using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringAndReportingSystem.Bots
{
    internal class RainBot
    {
        public int HumidityThreshold { get; set; }
        public string Message { get; set; } 
        public RainBot(int humidityThreshold, string message)
        {
            HumidityThreshold = humidityThreshold;
            Message = message;
        }
        public void Activate(int Humidity)
        {
            if (Humidity > HumidityThreshold)
                Console.WriteLine($"RainBot activated!\r\nRainBot: \"{Message}\"");
        }
    }
}
