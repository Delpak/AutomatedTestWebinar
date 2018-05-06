namespace AutomatedTestWebinar.Part1
{
    public class FisherMan
    {
        private readonly IAlarmService _alarmService;
        private readonly IWeatherForecaster _weatherForecaster;

        public FisherMan(IAlarmService alarmService = null, IWeatherForecaster weatherForecaster = null)
        {
            _alarmService = alarmService;
            _weatherForecaster = weatherForecaster;
        }
        public string Name { get; set; }

        public Level Level { get; set; }

        public bool Banned { get; set; }

        public void GoToFishing()
        {
            if (this.Level == Level.Amateur && 
                _weatherForecaster.WeatherStatus == WeatherStatus.Stormy &&
                _weatherForecaster.Temperature < 0)
            {
                _alarmService.PlayAlarm(2);
            }
            else if (this.Level == Level.Professional && _weatherForecaster.WeatherStatus == WeatherStatus.Stormy && _weatherForecaster.Temperature < 0)
            {
                _alarmService.PlayAlarm(1);
            }

        }
    }

    public enum Level
    {
        Amateur = 1,
        Professional = 2
    }
}
