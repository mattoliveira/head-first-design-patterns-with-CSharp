// See https://aka.ms/new-console-template for more information

using ObserverSimple.Observable;
using CurrentConditionsDisplay = ObserverSimple.Observers.CurrentConditionsDisplay;
using StatisticsDisplay = ObserverSimple.Observers.StatisticsDisplay;
using ForecastDisplay = ObserverSimple.Observers.ForecastDisplay;

WeatherData weatherData = new WeatherData();

CurrentConditionsDisplay currentDisplay = 
    new CurrentConditionsDisplay(weatherData);
StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);

weatherData.SetMeasurements(80, 65, 30.4f);
weatherData.SetMeasurements(82, 70, 29.2f);
weatherData.SetMeasurements(78, 90, 29.2f);
		
weatherData.RemoveObserver(forecastDisplay);
weatherData.SetMeasurements(62, 90, 28.1f);