using System;
using System.Collections.Generic;
using System.Text;

namespace kelvinCelsius
{   
      
    class Celsius
    {
        public double Cels { get; set; }
        public Celsius(double c)
        {
            Cels = c;
        }
        public static implicit operator Kelvin(Celsius celsius)
        {
            return new Kelvin(celsius.Cels + 273.15);
        }
    }
    class Kelvin
    {
        public double Kelv { get; set; }
        public Kelvin(double k)
        {
            Kelv = k;
        }


    }
   
}
