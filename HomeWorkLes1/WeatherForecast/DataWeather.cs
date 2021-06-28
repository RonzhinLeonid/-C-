using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Web;
using System.Net;
using System.Xml.Linq;

namespace WeatherForecast
{
    class DataWeather
    {
        WebClient client;
        public ObservableCollection<Forecast> Data { get; set; }
        
        public DataWeather()
        {
            Data = new ObservableCollection<Forecast>();
            client = new WebClient();

            this.AddCity("https://xml.meteoservice.ru/export/gismeteo/point/37.xml", "Москва");
            this.AddCity("https://xml.meteoservice.ru/export/gismeteo/point/5.xml", "Астрахань");
            this.AddCity("https://xml.meteoservice.ru/export/gismeteo/point/116.xml", "Сочи");
            this.AddCity("https://xml.meteoservice.ru/export/gismeteo/point/486.xml", "Казань");
            this.AddCity("https://xml.meteoservice.ru/export/gismeteo/point/486.xml", "Санкт-Петербург");
        }
        public DataWeather(string city)
        {
            Data = new ObservableCollection<Forecast>();
            client = new WebClient();
            switch (city)
            {
                case "Москва":
                this.AddCity("https://xml.meteoservice.ru/export/gismeteo/point/37.xml", city);
                    break;
                case "Астрахань":
                    this.AddCity("https://xml.meteoservice.ru/export/gismeteo/point/5.xml", city);
                    break;
                case "Сочи":
                    this.AddCity("https://xml.meteoservice.ru/export/gismeteo/point/116.xml", city);
                    break;
                case "Казань":
                    this.AddCity("https://xml.meteoservice.ru/export/gismeteo/point/486.xml", city);
                    break;
                case "Санкт-Петербург":
                    this.AddCity("https://xml.meteoservice.ru/export/gismeteo/point/69.xml", city);
                    break;
                default:
                    this.AddCity("https://xml.meteoservice.ru/export/gismeteo/point/37.xml", "Москва");
                    break;
            }
        }

        public void AddCity(string url, string name)
        {
            string xml = client.DownloadString(url);

            var list = XDocument.Parse(xml)
                        .Descendants("MMWEATHER")
                        .Descendants("REPORT")
                        .Descendants("TOWN")
                        .Descendants("FORECAST")
                        .ToList();

            foreach (var item in list)
            {
                var temp = new Forecast()
                            {
                                PressureMax = item.Element("PRESSURE").Attribute("max").Value,
                                PressureMin = item.Element("PRESSURE").Attribute("min").Value,
                                TemperatureMax = item.Element("TEMPERATURE").Attribute("max").Value,
                                TemperatureMin = item.Element("TEMPERATURE").Attribute("min").Value,
                                WindMax = item.Element("WIND").Attribute("max").Value,
                                WindMin = item.Element("WIND").Attribute("min").Value,
                                CityName = name,
                                Date = $"{item.Attribute("day").Value}.{item.Attribute("month").Value}.{item.Attribute("year").Value}" +
                                $" - {item.Attribute("hour").Value}:00"
                            };
                Data.Add(temp);
            }
        }
    }
}
