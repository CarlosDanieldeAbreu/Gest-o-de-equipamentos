using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2.ConsoleApp
{
    public class ConversorDeTemperatura
    {
        public decimal fahrenheit;

        public decimal calcularTemperatura()
        {
            decimal celcius = (fahrenheit - 32) / 1.8m;
            return celcius;
        }
    }
}
