using Microsoft.Extensions.Logging;
using NSubstitute;
using POCCICD1.Controllers;
using System;
using TechTalk.SpecFlow;

namespace POCCICD1.BDDTests
{
    [Binding]
    public class WeatherForecastSteps
    {
        private IEnumerable<WeatherForecast> _result;

        [Given(@"a user requests the weather forecast")]
        public void GivenAUserRequestsTheWeatherForecast()
        {
            // No action required for this step
        }

        [When(@"the weather forecast is retrieved")]
        public void WhenTheWeatherForecastIsRetrieved()
        {
            var logger = Substitute.For<ILogger<WeatherForecastController>>();
            var controller = new WeatherForecastController(logger);
            _result = controller.Get();
        }

        [Then(@"the user should receive the weather forecast for the next five days")]
        public void ThenTheUserShouldReceiveTheWeatherForecastForTheNextFiveDays()
        {
            Assert.That(_result, Is.Not.Null);
            Assert.That(_result, Is.InstanceOf<IEnumerable<WeatherForecast>>());
            Assert.That(_result.Count(), Is.EqualTo(5));
        }
    }

}
