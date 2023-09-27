using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringAndReportingSystem.Bots
{
    internal abstract class Bot
    {
        protected Subject subject;
        public abstract void Activate(int value);
    }
}
