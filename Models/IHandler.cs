using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringAndReportingSystem.Models
{
    internal interface IHandler
    {
        public WeatherData Parse(string data);
    }
}
