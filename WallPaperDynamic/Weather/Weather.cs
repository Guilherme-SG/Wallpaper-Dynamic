using System.Collections.Generic;

namespace WallPaperDynamic.Weather
{
    class Weather
    {
        public List<Dictionary<string, string>> weather = new List<Dictionary<string, string>>();

        public string GetWeather()
        {
            return weather[0]["main"];
        }
    }
}
