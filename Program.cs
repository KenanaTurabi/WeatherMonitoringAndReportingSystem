using WeatherMonitoringAndReportingSystem.Bots;
using WeatherMonitoringAndReportingSystem.Configurations;
using WeatherMonitoringAndReportingSystem.Models;

namespace WeatherMonitoringAndReportingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            BotConfigurations configurations = ConfigurationsReader.ReadFromJsonFile();
            if (configurations != null)
            {
                RainBot rainBot = new RainBot(configurations.RainBotConfiguration.humidityThreshold,configurations.RainBotConfiguration.message);
                SnowBot snowBot = new SnowBot(configurations.SnowBotConfiguration.temperatureThreshold, configurations.SnowBotConfiguration.message);
                SunBot sunBot = new SunBot(configurations.SunBotConfiguration.temperatureThreshold, configurations.SunBotConfiguration.message);
                Console.Write("Do you want to enter xml format or json format? ");
                string XmlOrJson = Console.ReadLine();
                if (string.Equals(XmlOrJson, "xml", StringComparison.OrdinalIgnoreCase))
                {
                    //<WeatherData><Location>City Name</Location><Temperature>32</Temperature><Humidity>40</Humidity></WeatherData>
                    Console.Write("Enter data in xml format:  ");
                    string xmlData = Console.ReadLine();
                    XmlFormatHandler xmlHandler = new XmlFormatHandler();
                    WeatherData weatherFromXml = xmlHandler.ParseXml(xmlData);
                    rainBot.Activate(weatherFromXml.Humidity);
                    snowBot.Activate(weatherFromXml.Temperature);
                    sunBot.Activate(weatherFromXml.Temperature);

                }

                else if (string.Equals(XmlOrJson, "json", StringComparison.OrdinalIgnoreCase))
                {
                    //{"Location": "City Name", "Temperature": 32, "Humidity": 40}
                    Console.Write("Enter data in json format:  ");
                    string jsonData = Console.ReadLine();
                    JsonFormatHandler jsonHandler = new JsonFormatHandler();
                    WeatherData weatherFromJson = jsonHandler.ParseJson(jsonData);
                    rainBot.Activate(weatherFromJson.Humidity);
                    snowBot.Activate(weatherFromJson.Temperature);
                    sunBot.Activate(weatherFromJson.Temperature);
                }
                else
                {
                    Console.WriteLine("invalid format");
                }

                

                

                

            }




        }
    }
}