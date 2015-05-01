using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemperatureConverterLibrary;
namespace Exercise2
{
    class TemperatureConversionExample
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(); // from our custom library refrence of TemperatureConverterLibrary
            double temperatureInCelcius = 35;
         
            double temperatureInFahrenheit = converter.convertToFahrenheit(temperatureInCelcius);
            Console.WriteLine("Temperature in celcius is {0} and in fahrenheit is {1} ",temperatureInCelcius,temperatureInFahrenheit);

            temperatureInFahrenheit = 99.99;
            temperatureInCelcius = converter.convertToCelcius(temperatureInFahrenheit);
            Console.WriteLine("Temperature in Farenheit is {0} and in celcius is {1} ",temperatureInFahrenheit, temperatureInCelcius);

        }
    }
}
