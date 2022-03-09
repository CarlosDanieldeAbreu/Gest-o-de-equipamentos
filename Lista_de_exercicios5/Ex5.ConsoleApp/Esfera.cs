using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5.ConsoleApp
{
    public class Esfera
    {
        public double raio;

        public double calcularEsfera()
        {
            double volume = (4 * Math.PI * Math.Pow(raio, 3)) / 3;
            return volume;
        }
    }
}
