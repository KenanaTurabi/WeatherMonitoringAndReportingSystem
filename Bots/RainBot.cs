using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringAndReportingSystem.Bots
{
    internal class RainBot : Bot
    {
        public int HumidityThreshold { get; set; }
        public string Message { get; set; } 
        public RainBot(Subject subject,int humidityThreshold, string message)
        {
            this.subject = subject;
            HumidityThreshold = humidityThreshold;
            Message = message;
            this.subject.Attach(this);
        }
        public override void Activate(int Humidity)
        {
            if (Humidity > HumidityThreshold)
                Console.WriteLine($"RainBot activated!\r\nRainBot: \"{Message}\"");
        }
    }
}
