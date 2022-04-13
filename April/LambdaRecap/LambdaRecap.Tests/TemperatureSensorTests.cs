using Xunit;

namespace LambdaRecap.Tests
{
    public class TemperatureSensorTests
    {
        [Fact]
        public void ReadTemperatureTest()
        {
            // Call ReadTemperature and make sure that TemperatureChanged event has been fired

            var eventFired = false;
            var temperatureSensor = new TemperatureSensor();
            temperatureSensor.TemperatureChanged += (sender, args) => eventFired = true;
            temperatureSensor.ReadTemperature();
            Assert.True(eventFired);
        }
    }
}