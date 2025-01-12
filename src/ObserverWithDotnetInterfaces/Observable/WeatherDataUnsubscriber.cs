namespace ObserverWithDotnetInterfaces.Observable;

public class WeatherDataUnsubscriber : IDisposable
{
    private readonly ISet<IObserver<WeatherInfo>> _observers;
    private readonly IObserver<WeatherInfo> _observer;

    public WeatherDataUnsubscriber(
        ISet<IObserver<WeatherInfo>> observers,
        IObserver<WeatherInfo> observer) => (_observers, _observer) = (observers, observer);
    
    public void Dispose()
    {
        _observers.Remove(_observer);
    }
}