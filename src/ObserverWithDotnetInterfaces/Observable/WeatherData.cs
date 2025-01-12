namespace ObserverWithDotnetInterfaces.Observable;

public class WeatherData : IObservable<WeatherInfo>
{
    private readonly HashSet<IObserver<WeatherInfo>> _observers = new();
    
    public IDisposable Subscribe(IObserver<WeatherInfo> observer)
    {
        if (!_observers.Contains(observer))
        {
            _observers.Add(observer);
        }
        
        return new WeatherDataUnsubscriber(_observers, observer);
    }
    
    public void SetWeatherInfo(WeatherInfo weatherInfo)
    {
        foreach (var observer in _observers)
        {
            observer.OnNext(weatherInfo);
        }
    }
}