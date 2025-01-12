using ObserverWithDotnetInterfaces.Interfaces;

namespace ObserverWithDotnetInterfaces.Observers;

public class ForecastDisplay: IObserver<WeatherInfo>, IDisplayElement
{
    private IDisposable? _cancellation;
    private float currentPressure = 29.92f;  
    private float lastPressure;
    
    private WeatherInfo _weatherInfo;

    public ForecastDisplay(IObservable<WeatherInfo> observable)
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
        lastPressure = currentPressure;
        currentPressure = value.Pressure;
        _weatherInfo = value;
        Display();
    }

    public void Display()
    {
        Console.Write($"Forecast:");
        if (currentPressure > lastPressure) {
            Console.WriteLine("Improving weather on the way!");
        } else if (currentPressure == lastPressure) {
            Console.WriteLine("More of the same");
        } else if (currentPressure < lastPressure) {
            Console.WriteLine("Watch out for cooler, rainy weather");
        }
    }
}