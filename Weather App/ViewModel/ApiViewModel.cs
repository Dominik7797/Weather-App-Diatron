using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using Weather_App.Model;

namespace Weather_App.ViewModel
{
    class ApiViewModel
    {
        private const string _APIKEY = "http://api.openweathermap.org/data/2.5/forecast?q=Budapest&units=metric&appid=b03caa60c8b499890c552d1690aaccb6";

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

            foreach (var item in weatherData.List)
            {
                var avg = Convert.ToInt32(item.Main.Temp);
                resultDict.Add(item.DtTxt, avg);
            }

            CountAvgPerDay(resultDict);
            return null;
        }

        private void CountAvgPerDay(Dictionary<string, int> resultDict)
        {
            var avgPerDay = new Dictionary<string, int>();
            var avgTemp = 0; 

            foreach (var kvp in resultDict)
            {
                var splittDatetime = kvp.Key.Split(' ');
                var dateTime = splittDatetime[0];
                if (avgPerDay.ContainsKey(dateTime))
                {
                    avgTemp += kvp.Value()
                }
            }
        }
    }
}
