namespace AutomatedTestWebinar.Part1
{
    public class WeatherForecaster : IWeatherForecaster
    {
        public int Temperature
        {
            get
            {
                //TODO: Call web Api https://www.accuweather.com/fa/ir/iran-weather
                return 35;
            }
        }

        public WeatherStatus WeatherStatus
        {
            get
            {
                //TODO: Call web Api https://www.accuweather.com/fa/ir/iran-weather
                return WeatherStatus.Sunny;
            }
        }
    }
}