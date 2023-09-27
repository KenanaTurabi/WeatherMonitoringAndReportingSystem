using System.Xml.Linq;
using WeatherMonitoringAndReportingSystem.Bots;
using WeatherMonitoringAndReportingSystem.Configurations;
using WeatherMonitoringAndReportingSystem.Models;
using System.Xml;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace WeatherMonitoringAndReportingSystem
{
    internal class Program
    {
        public static bool IsJson(string data)
        {
            try
            {
                JToken.Parse(data);
                return true;    
            }
            catch (JsonReaderException)
            {
                return false;
            }
        }
        public static bool IsXml(string data)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(data);
                return true;
            }
            catch (XmlException)
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            IHandler Handler;
            FormatFactory formatFactory=new FormatFactory();
            BotConfigurations configurations = ConfigurationsReader.ReadFromJsonFile();
            if (configurations != null)
            {
                RainBot rainBot = new RainBot(configurations.RainBotConfiguration.humidityThreshold,configurations.RainBotConfiguration.message);
                SnowBot snowBot = new SnowBot(configurations.SnowBotConfiguration.temperatureThreshold, configurations.SnowBotConfiguration.message);
                SunBot sunBot = new SunBot(configurations.SunBotConfiguration.temperatureThreshold, configurations.SunBotConfiguration.message);
                Console.Write("plz enter data in xml format or json format: ");
                string data = Console.ReadLine();
                //<WeatherData><Location>City Name</Location><Temperature>32</Temperature><Humidity>40</Humidity></WeatherData>
                //{"Location": "City Name", "Temperature": 32, "Humidity": 40}
                string type;
                if (IsJson(data))
                {
                    Console.WriteLine("The data is in JSON format.");
                    type = "json";
                }
                else if (IsXml(data))
                {
                    Console.WriteLine("The data is in XML format.");
                    type = "Xml";

                }
                else
                {
                    Console.WriteLine("The data is in Unkown format.");
                    type = "Unkown";
                }
                if (formatFactory.getFormateType(type) == null)
                {
                    Console.WriteLine("invalid format");
                }
                else
                {
                    Handler = formatFactory.getFormateType(type);
                    WeatherData weatherData = Handler.Parse(data);
                    rainBot.Activate(weatherData.Humidity);
                    snowBot.Activate(weatherData.Temperature);
                    sunBot.Activate(weatherData.Temperature);
                }
            }
        }
    }
}