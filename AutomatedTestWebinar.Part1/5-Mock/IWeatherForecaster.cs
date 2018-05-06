namespace AutomatedTestWebinar.Part1
{
    public interface IWeatherForecaster
    {
        int Temperature { get; }
        WeatherStatus WeatherStatus { get; }
    }
}