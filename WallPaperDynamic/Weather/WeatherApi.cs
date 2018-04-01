using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using WallPaperDynamic.File;

namespace WallPaperDynamic.Weather
{
    class WeatherApi
    {
        private WeatherApiConfig config;

        public WeatherApi()
        {
            config = WeatherApiConfig.GetApiConfig();
        }

        public string GetWeather()
        {
            try
            {
                if (config == null)
                {
                    // It's impossible to make a weather request without configs
                    // so we'll use default weather
                    return "Clear";
                }

                string url = $"http://api.openweathermap.org/data/2.5/weather/?id={config.CityId}&appid={config.Key}";

                using (WebClient client = new WebClient())
                {
                    // Get weather data in string json
                    string content = client.DownloadString(url);

                    // Convert string json to Object
                    Weather weather = new Weather();
                    JsonConvert.PopulateObject(content, weather);

                    // Return the main
                    return weather.GetWeather();
                }
            }
            catch (WebException)
            {
                // Default weather
                return "Clear";
            }
        }
    }
}
