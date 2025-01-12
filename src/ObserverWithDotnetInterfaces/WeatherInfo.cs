namespace ObserverWithDotnetInterfaces;

public struct WeatherInfo
{
    public WeatherInfo(float temperature, float humidity, float pressure)
    {
        Temperature = temperature;
        Humidity = humidity;
        Pressure = pressure;
    }
    public float Temperature { get; private set; }
    public float Humidity { get; private set; }
    public float Pressure { get; private set; }
}