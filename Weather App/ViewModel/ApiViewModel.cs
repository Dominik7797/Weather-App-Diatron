using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using Weather_App.Model;

namespace Weather_App.ViewModel
{
    class ApiViewModel
    {
        private const string _APIKEY = "https://api.openweathermap.org/data/2.5/onecall?lat=47.497913&lon=19.040236&exclude=alerts,current,minutely,hourly,&units=metric&appid=b03caa60c8b499890c552d1690aaccb6";

        public WeatherData.Root GetWeatherForcast()
        {
            using (var webClient = new WebClient())
            {
                var rawJson = webClient.DownloadString(_APIKEY);
                var result = JsonConvert.DeserializeObject<WeatherData.Root>(rawJson);
                return result;
            }
        }

        public Dictionary<string, int> GetTemps(WeatherData.Root weatherData)
        {
            var resultDict = new Dictionary<string, int>();

            foreach (var item in weatherData.Daily)
            {
                var convertedDateTime = UnixTimeToDateTime(item.Dt);
                Console.WriteLine(convertedDateTime);
                int avgTemp = Convert.ToInt32(item.Temp.Day);
                resultDict.Add(convertedDateTime.ToString(), avgTemp); ;
            }

            return resultDict;
        }

        public string UnixTimeToDateTime(long unixtime)
        {
            System.DateTime dateTime = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            dateTime = dateTime.AddSeconds(unixtime);
            return dateTime.ToShortDateString();
        }
    }
}
