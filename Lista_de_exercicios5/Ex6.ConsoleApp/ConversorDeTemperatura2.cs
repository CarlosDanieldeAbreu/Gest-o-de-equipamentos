using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6.ConsoleApp
{
    internal class ConversorDeTemperatura2
    {
        public decimal celcius;

        public decimal calcularTemperatura()
        {
            decimal fahrenheit = (celcius * 1.8m) + 32;
            return fahrenheit;
        }
    }
}
