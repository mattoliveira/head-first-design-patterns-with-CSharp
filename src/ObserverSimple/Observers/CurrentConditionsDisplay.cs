using ObserverSimple.Interfaces;
using ObserverSimple.Observable;

namespace ObserverSimple.Observers;

public class CurrentConditionsDisplay : IObserver, IDisplayElement
{
    private float temperature;
    private float humidity;
    private WeatherData weatherData;
    
    public CurrentConditionsDisplay(WeatherData weatherData) {
        this.weatherData = weatherData;
        weatherData.RegisterObserver(this);
    }
    public void Update(float temp, float humidity, float pressure)
    {
        temperature = temp;
        this.humidity = humidity;
    }

    public void Display()
    {
        Console.WriteLine($"Current conditions: {temperature}F degrees and {humidity} humidity");
    }
}