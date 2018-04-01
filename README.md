# Wallpaper-Dynamic
My desktop application in C# that changes the background windows depending on the time and the weather

# Backgrounds
All background images have to be in data/images/ and they have do be JPG. In the same folder put a deafult background named void.jpg, this image will be used when is not defined a exact image for actual time and weather.
## Weather
Wallpaper-Dynamic makes weather requests each 10 minutes, this way your background will approch to reality and API's limit won't be exceeded.
Each weather will be your own folder named with the weather, there you'll be able to put images to be your background in repective weather. Ex: If the wheather is Rain, you have to put images in data/images/Rain.

The aplication are using weather data from OpenWeatherMap API. 
API link: https://openweathermap.org/api

To it works, you have to create a file in data/config named weatherAPI.json
```JSON
{
  "key": "your key provided by weather api",
  "cityId": "city that you want to get data"
}
```
## Time
