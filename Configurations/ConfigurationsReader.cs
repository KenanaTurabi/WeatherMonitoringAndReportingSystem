using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringAndReportingSystem.Configurations
{
    internal class ConfigurationsReader
    { 
        public static BotConfigurations ReadFromJsonFile()
        {
            try
            {
                string configurationText = File.ReadAllText("config.json");
                BotConfigurations botConfigurations = JsonConvert.DeserializeObject<BotConfigurations>(configurationText);
                return botConfigurations;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return null;
            }
           
        }
    }
}
