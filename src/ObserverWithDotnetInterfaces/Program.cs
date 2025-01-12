// See https://aka.ms/new-console-template for more information

using ObserverWithDotnetInterfaces;
using ObserverWithDotnetInterfaces.Observable;
using ObserverWithDotnetInterfaces.Observers;

WeatherData weatherData = new WeatherData();

CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);

weatherData.SetWeatherInfo(new WeatherInfo(80, 65,30.4f));
weatherData.SetWeatherInfo(new WeatherInfo(82, 70,29.2f));
weatherData.SetWeatherInfo(new WeatherInfo(78, 90,29.2F));

forecastDisplay.Unsubscribe();

weatherData.SetWeatherInfo(new WeatherInfo(62, 90,28.1f));
