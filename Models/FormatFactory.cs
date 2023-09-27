using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringAndReportingSystem.Models
{
    internal class FormatFactory
    {
        public IHandler getFormateType(string Formate)
        {
            if(string.Equals(Formate, "xml", StringComparison.OrdinalIgnoreCase))
            {
                return new XmlFormatHandler();
            }
            else if(string.Equals(Formate, "json", StringComparison.OrdinalIgnoreCase))
            {
                return new JsonFormatHandler();
            }
            else
            {
                return null;
            }
        }
    }
}
