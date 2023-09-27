using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringAndReportingSystem.Bots
{
    internal class Subject
    {
        private List <Bot>Bots = new List<Bot>();
        public void Attach(Bot bot)
        {
            Bots.Add(bot);
        }
        public void NotifyAll(int temperature,int humidity)
        {
            foreach (Bot bot in Bots)
            {
                if (bot is RainBot)
                {
                    bot.Activate(humidity);
                }
                else
                {
                    bot.Activate(temperature);
                }
            }
        }
    }
}
