using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringAndReportingSystem.Bots
{
    internal class SunBot : Bot
    {
        public int TempertaureThreshold { get; set; }
        public string Message { get; set; }

        public SunBot(Subject subject,int tempertaureThreshold, string message)
        {
            this.subject = subject;
            TempertaureThreshold = tempertaureThreshold;
            Message = message;
            this.subject.Attach(this);
        }
        public override void Activate(int Temperature)
        {
            if (Temperature > TempertaureThreshold)
            {
                Console.WriteLine($"SunBot activated!\r\nSunBot: \"{Message}\"");
            }
        }
    }
}
