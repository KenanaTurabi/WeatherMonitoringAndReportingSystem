using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace WeatherMonitoringAndReportingSystem.Models
{
    internal class XmlFormatHandler
    {
            public WeatherData ParseXml(string xmlData)
            {
                try
                {
                    XElement root = XElement.Parse(xmlData);
                    WeatherData weatherData = new WeatherData
                    {
                        Location = root.Element("Location").Value,
                        Temperature = Convert.ToInt32(root.Element("Temperature").Value),
                        Humidity = Convert.ToInt32(root.Element("Humidity").Value)
                    };

                    return weatherData;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error parsing XML data: {ex.Message}");
                    return null;
                }
            }
    }




}

