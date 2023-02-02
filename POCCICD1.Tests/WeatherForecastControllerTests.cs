using Microsoft.Extensions.Logging;
using NSubstitute;
using POCCICD1.Controllers;

namespace POCCICD1.Tests
{
    [TestFixture]
    public class WeatherForecastControllerTests
    {
        [Test]
        public void Get_Returns_WeatherForecasts()
        {
            // Arrange
            var logger = Substitute.For<ILogger<WeatherForecastController>>();
            var controller = new WeatherForecastController(logger);

            // Act
            var result = controller.Get();

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.InstanceOf<IEnumerable<WeatherForecast>>());
        }
    }
}
