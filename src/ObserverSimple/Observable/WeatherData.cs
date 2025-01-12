using ObserverSimple.Interfaces;

namespace ObserverSimple.Observable;

public class WeatherData : ISubject
{
    private float _temperature;
    private float _humidity;
    private float _pressure;
    
    private List<IObserver> _observers;

    public WeatherData()
    {
        _observers = new List<IObserver>();
    }
    
    public void RegisterObserver(IObserver o)
    {
        _observers.Add(o);
    }

    public void RemoveObserver(IObserver o)
    {
        _observers.Remove(o);
    }

    public void NotifyObservers()
    {
        foreach (var o in _observers)
        {
            o.Update(_temperature, _humidity, _pressure);
        }
    }
    
    public void MeasurementsChanged() {
        NotifyObservers();
    }
    
    public void SetMeasurements(float temperature, float humidity, float pressure) {
        _temperature = temperature;
        _humidity = humidity;
        _pressure = pressure;
        MeasurementsChanged();
    }
    
    public float GetTemperature() {
        return _temperature;
    }
	
    public float GetHumidity() {
        return _humidity;
    }
	
    public float GetPressure() {
        return _pressure;
    }
}