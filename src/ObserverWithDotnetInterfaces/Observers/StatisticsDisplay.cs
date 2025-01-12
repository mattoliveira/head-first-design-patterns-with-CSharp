using ObserverWithDotnetInterfaces.Interfaces;

namespace ObserverWithDotnetInterfaces.Observers;

public class StatisticsDisplay : IObserver<WeatherInfo>, IDisplayElement
{
    private float maxTemp = 0.0f;
    private float minTemp = 200;
    private float tempSum = 0.0f;
    private int numReadings = 0;
    
    private IDisposable? _cancellation;

    public StatisticsDisplay(IObservable<WeatherInfo> observable)
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
        tempSum += value.Temperature;
        numReadings++;

        if (value.Temperature > maxTemp) {
            maxTemp = value.Temperature;
        }
 
        if (value.Temperature < minTemp) {
            minTemp = value.Temperature;
        }
        Display();
    }

    public void Display()
    {
        Console.WriteLine($"Avg/Max/Min temperature = {(tempSum / numReadings)}/{maxTemp}/{minTemp}");
    }
}