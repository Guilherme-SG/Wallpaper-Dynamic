using Microsoft.Win32;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WallPaperDynamic.File;
using WallPaperDynamic.Weather;

namespace WallPaperDynamic.Background
{
    class BackgroundController
    {
        private string fileName;
        private const int SetDeskWallpaper = 20;
        private const int UpdateIniFile = 0x01;
        private const int SendWinIniChange = 0x02;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        private string weather;
        private DirectoryController controller;

        public BackgroundController()
        {           
            weather = "Clear";
            controller = new DirectoryController();
        }

        public void ChooseBackgroundImage()
        {
            fileName = controller.GetImagePath(weather, getImageIndexByHour());
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);
            SystemParametersInfo(SetDeskWallpaper, 0, fileName, UpdateIniFile | SendWinIniChange);
        }

        public void DefineBackgroundWeather(WeatherApi api)
        {
            // Define which group images to use
            weather = api.GetWeather();
        }

        public void ShowBackgroundWeatherMessage()
        {
            MessageBox.Show($"The weather is {weather}");
        }

        private int getImageIndexByHour()
        {
            // Define a image to use
            int hour = DateTime.Now.Hour;
            int index = 7;

            if (hour >= 0 && hour <= 2)
                index = 0;

            else if (hour >= 3 && hour <= 5)
                index = 1;

            else if (hour >= 6 && hour <= 8)
                index = 2;

            else if (hour >= 9 && hour <= 11)
                index = 3;

            else if (hour >= 12 && hour <= 14)
                index = 4;

            else if (hour >= 15 && hour <= 17)
                index = 5;

            else if (hour >= 18 && hour <= 20)
                index = 6;

            return index;
        }
    }
}
