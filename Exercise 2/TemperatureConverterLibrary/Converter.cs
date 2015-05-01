using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverterLibrary
{
    public class Converter
    {

        public double convertToCelcius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        public double convertToFahrenheit(double celcius)
        {
            return celcius * 9/5 + 32;
        }
    }
}
