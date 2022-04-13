using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaRecap
{
    public class TemperatureSensor
    {
        public event EventHandler<double> TemperatureChanged;

        public void ReadTemperature()
        {
            // Here we would read the temperature from the sensor
            var temp = 42d;

            TemperatureChanged?.Invoke(this, temp);
        }
    }
}
