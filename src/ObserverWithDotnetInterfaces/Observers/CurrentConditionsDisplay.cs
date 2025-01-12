using ObserverWithDotnetInterfaces.Interfaces;

namespace ObserverWithDotnetInterfaces.Observers;

public class CurrentConditionsDisplay : IObserver<WeatherInfo>, IDisplayElement
{
    private IDisposable? _cancellation;
    private WeatherInfo _weatherInfo;

    public CurrentConditionsDisplay(IObservable<WeatherInfo> observable)
    {
        _cancellation = observable.Subscribe(this);
    }
    
    public virtual void Unsubscribe()
    {
        _cancellation?.Dispose();
    }
    public void OnCompleted()
    {
        Console.WriteLine("Completed");
    }

    public void OnError(Exception error)
    {
        Console.WriteLine("Error");
    }

    public void OnNext(WeatherInfo value)
    {
        _weatherInfo = value;
        Display();
    }

    public void Display()
    {
        Console.WriteLine($"Current conditions: {_weatherInfo.Temperature}F degrees and {_weatherInfo.Humidity} humidity");
    }
}