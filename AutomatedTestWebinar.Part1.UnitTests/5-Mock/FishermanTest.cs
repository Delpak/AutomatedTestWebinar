using Moq;
using NUnit.Framework;

namespace AutomatedTestWebinar.Part1.UnitTests
{
    [TestFixture]
    public class FishermanTest
    {
        [Test]
        public void GoToFishing_WhenAmateurFisherman_InStormyWeather_TemperatureIsBelowZero_AlwaysCallsAlarmServiceWithArgument2()
        {
            //Arrange
            var weatherForecasterStub = new Mock<IWeatherForecaster>();
            weatherForecasterStub.Setup(forecaster => forecaster.WeatherStatus).Returns(WeatherStatus.Stormy);
            weatherForecasterStub.Setup(forecaster => forecaster.Temperature).Returns(-1);

            var alarmServiceMock = new Mock<IAlarmService>();

            var fisherMan = new FisherMan(alarmServiceMock.Object, weatherForecasterStub.Object)
            {
                Level = Level.Amateur,
                Name = "Hasan"
            };

            //Act
            fisherMan.GoToFishing();

            //Assert
            alarmServiceMock.Verify(service => service.PlayAlarm(2));

        }

        [Test]
        public void GoToFishing_WhenProfessionalFisherman_InStormyWeather_TemperatureIsBelowZero_AlwaysCallsAlarmServiceWithArgument1()
        {
            //Arrange
            var weatherForecasterStub = new Mock<IWeatherForecaster>();
            weatherForecasterStub.Setup(forecaster => forecaster.WeatherStatus).Returns(WeatherStatus.Stormy);
            weatherForecasterStub.Setup(forecaster => forecaster.Temperature).Returns(-1);

            var alarmServiceMock = new Mock<IAlarmService>();

            var fisherMan = new FisherMan(alarmServiceMock.Object, weatherForecasterStub.Object)
            {
                Level = Level.Professional,
                Name = "Hasan"
            };

            //Act
            fisherMan.GoToFishing();

            //Assert
            alarmServiceMock.Verify(service => service.PlayAlarm(1));

        }

        #region WithTestCase
        [Test]
        [TestCase(Level.Amateur, 2)]
        [TestCase(Level.Professional, 1)]
        public void GoToFishing_InStormyWeather_TemperatureIsBelowZero_AlwaysCallsAlarmService(Level level, int alarmVolume)
        {
            //Arrange
            var weatherForecasterStub = new Mock<IWeatherForecaster>();
            weatherForecasterStub.Setup(forecaster => forecaster.WeatherStatus).Returns(WeatherStatus.Stormy);
            weatherForecasterStub.Setup(forecaster => forecaster.Temperature).Returns(-1);

            var alarmServiceMock = new Mock<IAlarmService>();

            var fisherMan = new FisherMan(alarmServiceMock.Object, weatherForecasterStub.Object)
            {
                Level = level,
                Name = "Hasan"
            };

            //Act
            fisherMan.GoToFishing();

            //Assert
            alarmServiceMock.Verify(service => service.PlayAlarm(alarmVolume));

        }
        #endregion

    }
}