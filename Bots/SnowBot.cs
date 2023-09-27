using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringAndReportingSystem.Bots
{
    internal class SnowBot:Bot
    {
        public int TemperatureThreshold { get; set; }
        public string Message { get; set; }

        public SnowBot(Subject subject,int temperatureThreshold, string message)
        {
            this.subject = subject;
            TemperatureThreshold = temperatureThreshold;
            Message = message;
            this.subject.Attach(this);
        }
        public override void Activate(int Temperature)
        {
            if (Temperature < TemperatureThreshold)
            {
                Console.WriteLine($"SnowBot activated!\r\nSnowBot: \"{Message}\"");

            }

        }
    }
}
