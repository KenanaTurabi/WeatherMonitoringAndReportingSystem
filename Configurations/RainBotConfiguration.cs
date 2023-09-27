using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringAndReportingSystem.Configurations
{
    internal class RainBotConfiguration
    {
            public bool enabled { get; set; }
            public int humidityThreshold { get; set; }
            public string message { get; set; }
        
    }
}
