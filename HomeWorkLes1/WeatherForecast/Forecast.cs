using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast
{
    class Forecast
    {
        public string CityName { get; set; }
        public string Date { get; set; }
        
        private string WindMaxField;
        private string WindMinField;

        private string PressureMaxField;
        private string PressureMinField;

        private string TemperatureMaxField;
        private string TemperatureMinField;

        public string WindMax { set { WindMaxField = value; } }
        public string WindMin { set { WindMinField = value; } }
        public string Wind { get { return $"{WindMinField} - {WindMaxField} м/с"; } }
        public string PressureMax { set { PressureMaxField = value; } }
        public string PressureMin { set { PressureMinField = value; } }
        public string Pressure { get { return $"{PressureMinField} - {PressureMaxField} мм.рт.ст."; } }
        public string TemperatureMax { set { TemperatureMaxField = value; } }
        public string TemperatureMin { set { TemperatureMinField = value; } }
        public string Temperature { get { return $"{TemperatureMinField} - {TemperatureMaxField} °c"; } }
    }
}
