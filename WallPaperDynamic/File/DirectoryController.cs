using System;
using System.IO;
using System.Linq;

namespace WallPaperDynamic.File
{
    class DirectoryController
    {
        private string imageBasePath;
        private string configBasePath;
        private string defaultImage;

        public DirectoryController()
        {
            imageBasePath = @"data\images";
            configBasePath = @"data\config";
            defaultImage = "void.jpg";
        }

        public string GetImagePath(string weather, int imageIndex)
        {
            try
            {
                string path = Path.Combine(imageBasePath, weather);

                // Find the images on the path
                var directory = new DirectoryInfo(path);
                var fileNames = directory.GetFiles().ToArray();
                return Path.Combine(path, fileNames[imageIndex].ToString());
            }
            catch (DirectoryNotFoundException)
            {
                // Ensures that directory will exist in next time
                createImageDirectory(imageBasePath, weather);

                // Uses a default image
                return Path.Combine(imageBasePath, defaultImage);                
            }
            catch (IndexOutOfRangeException)
            {                
                // Didn't exist a image, so let define a default image
                return Path.Combine(imageBasePath, defaultImage);
            }
        }

        private void createImageDirectory(string basePath, string weather)
        {
            string path = Path.Combine(basePath, weather);

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        public string GetConfigPath(string name)
        {
            return Path.Combine(configBasePath, name);
        }
    }
}
