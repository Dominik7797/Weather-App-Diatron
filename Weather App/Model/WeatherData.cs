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
        public class Temp
        {
            [JsonProperty("day")]
            public double Day { get; set; }

            [JsonProperty("min")]
            public double Min { get; set; }

            [JsonProperty("max")]
            public double Max { get; set; }

            [JsonProperty("night")]
            public double Night { get; set; }

            [JsonProperty("eve")]
            public double Eve { get; set; }

            [JsonProperty("morn")]
            public double Morn { get; set; }
        }

        public class FeelsLike
        {
            [JsonProperty("day")]
            public double Day { get; set; }

            [JsonProperty("night")]
            public double Night { get; set; }

            [JsonProperty("eve")]
            public double Eve { get; set; }

            [JsonProperty("morn")]
            public double Morn { get; set; }
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

        public class Daily
        {
            [JsonProperty("dt")]
            public int Dt { get; set; }

            [JsonProperty("sunrise")]
            public int Sunrise { get; set; }

            [JsonProperty("sunset")]
            public int Sunset { get; set; }

            [JsonProperty("moonrise")]
            public int Moonrise { get; set; }

            [JsonProperty("moonset")]
            public int Moonset { get; set; }

            [JsonProperty("moon_phase")]
            public double MoonPhase { get; set; }

            [JsonProperty("temp")]
            public Temp Temp { get; set; }

            [JsonProperty("feels_like")]
            public FeelsLike FeelsLike { get; set; }

            [JsonProperty("pressure")]
            public int Pressure { get; set; }

            [JsonProperty("humidity")]
            public int Humidity { get; set; }

            [JsonProperty("dew_point")]
            public double DewPoint { get; set; }

            [JsonProperty("wind_speed")]
            public double WindSpeed { get; set; }

            [JsonProperty("wind_deg")]
            public int WindDeg { get; set; }

            [JsonProperty("wind_gust")]
            public double WindGust { get; set; }

            [JsonProperty("weather")]
            public List<Weather> Weather { get; set; }

            [JsonProperty("clouds")]
            public int Clouds { get; set; }

            [JsonProperty("pop")]
            public double Pop { get; set; }

            [JsonProperty("rain")]
            public double Rain { get; set; }

            [JsonProperty("uvi")]
            public double Uvi { get; set; }
        }

        public class Root
        {
            [JsonProperty("lat")]
            public double Lat { get; set; }

            [JsonProperty("lon")]
            public double Lon { get; set; }

            [JsonProperty("timezone")]
            public string Timezone { get; set; }

            [JsonProperty("timezone_offset")]
            public int TimezoneOffset { get; set; }

            [JsonProperty("daily")]
            public List<Daily> Daily { get; set; }
        }


    }
}
