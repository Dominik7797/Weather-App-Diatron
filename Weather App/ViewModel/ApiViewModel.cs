using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Weather_App.Model;

namespace Weather_App.ViewModel
{
    class ApiViewModel
    {
        private const string _APIKEY = "http://api.openweathermap.org/data/2.5/forecast?q=Budapest&units=metric&appid=b03caa60c8b499890c552d1690aaccb6";

        public WeatherData.Root GetWeatherForcast()
        {
            using(var webClient = new WebClient())
            {
                var rawJson = webClient.DownloadString(_APIKEY);
                var result = JsonConvert.DeserializeObject<WeatherData.Root>(rawJson);
                return result;
            }
        }
    }
}
