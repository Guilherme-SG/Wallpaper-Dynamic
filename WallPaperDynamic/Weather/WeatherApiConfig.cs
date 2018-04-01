using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;
using WallPaperDynamic.File;

namespace WallPaperDynamic.Weather
{
    class WeatherApiConfig
    {
        private string key;
        private string cityId;

        public string Key
        {
            get
            {
                return key;
            }

            set
            {
                key = value;
            }
        }

        public string CityId
        {
            get
            {
                return cityId;
            }

            set
            {
                cityId = value;
            }
        }

        public static WeatherApiConfig GetApiConfig()
        {
            try
            {
                DirectoryController directory = new DirectoryController();
                using (StreamReader reader = new StreamReader(directory.GetConfigPath("weatherAPI.json")))
                {
                    string json = reader.ReadToEnd();
                    return JsonConvert.DeserializeObject<WeatherApiConfig>(json);
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File 'weatherAPI.json' not found", "Something is wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("File 'weatherAPI.json' not found", "Something is wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
