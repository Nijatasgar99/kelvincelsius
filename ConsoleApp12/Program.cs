using System;

namespace kelvinCelsius
{
    class Program
    {
        static void Main(string[] args)
        {
            Celsius celsius = new Celsius(10);
            Kelvin kelvin = celsius;
            Console.WriteLine(kelvin.Kelv);
        }
    }
}
