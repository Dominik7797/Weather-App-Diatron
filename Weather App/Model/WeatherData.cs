using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_App.Model
{
    public class WeatherData
    {
        public class Main
        {
            [JsonProperty("temp")]
            public double Temp { get; set; }

            [JsonProperty("feels_like")]
            public double FeelsLike { get; set; }

            [JsonProperty("temp_min")]
            public double TempMin { get; set; }

            [JsonProperty("temp_max")]
            public double TempMax { get; set; }

            [JsonProperty("pressure")]
            public int Pressure { get; set; }

            [JsonProperty("sea_level")]
            public int SeaLevel { get; set; }

            [JsonProperty("grnd_level")]
            public int GrndLevel { get; set; }

            [JsonProperty("humidity")]
            public int Humidity { get; set; }

            [JsonProperty("temp_kf")]
            public double TempKf { get; set; }
        }

        public class Weather
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("main")]
            public string Main { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("icon")]
            public string Icon { get; set; }
        }

        public class Clouds
        {
            [JsonProperty("all")]
            public int All { get; set; }
        }

        public class Wind
        {
            [JsonProperty("speed")]
            public double Speed { get; set; }

            [JsonProperty("deg")]
            public int Deg { get; set; }

            [JsonProperty("gust")]
            public double Gust { get; set; }
        }

        public class Rain
        {
            [JsonProperty("3h")]
            public double _3h { get; set; }
        }

        public class Sys
        {
            [JsonProperty("pod")]
            public string Pod { get; set; }
        }

        public class List
        {
            [JsonProperty("dt")]
            public int Dt { get; set; }

            [JsonProperty("main")]
            public Main Main { get; set; }

            [JsonProperty("weather")]
            public List<Weather> Weather { get; set; }

            [JsonProperty("clouds")]
            public Clouds Clouds { get; set; }

            [JsonProperty("wind")]
            public Wind Wind { get; set; }

            [JsonProperty("visibility")]
            public int Visibility { get; set; }

            [JsonProperty("pop")]
            public double Pop { get; set; }

            [JsonProperty("rain")]
            public Rain Rain { get; set; }

            [JsonProperty("sys")]
            public Sys Sys { get; set; }

            [JsonProperty("dt_txt")]
            public string DtTxt { get; set; }
        }

        public class City
        {
        }

        public class Root
        {
            [JsonProperty("cod")]
            public string Cod { get; set; }

            [JsonProperty("message")]
            public int Message { get; set; }

            [JsonProperty("cnt")]
            public int Cnt { get; set; }

            [JsonProperty("list")]
            public List<List> List { get; set; }

            [JsonProperty("city")]
            public City City { get; set; }
        }
    }
}
