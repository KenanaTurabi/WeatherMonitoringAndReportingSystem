using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringAndReportingSystem.Configurations
{
    internal class SunBotConfiguration
    {
        public int temperatureThreshold { get; set; }
        public bool enabled { get; set; }
        public string message { get; set; }
    }
}
