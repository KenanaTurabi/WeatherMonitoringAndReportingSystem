using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringAndReportingSystem.Bots
{
    internal class SunBot
    {
        public int TempertaureThreshold { get; set; }
        public string Message { get; set; }

        public SunBot(int tempertaureThreshold, string message)
        {
            TempertaureThreshold = tempertaureThreshold;
            Message = message;
        }
        public void Activate(int Temperature)
        {
            if (Temperature > TempertaureThreshold)
            {
                Console.WriteLine($"SunBot activated!\r\nSunBot: \"{Message}\"");
            }
        }
    }
}
