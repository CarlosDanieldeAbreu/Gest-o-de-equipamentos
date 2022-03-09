using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8.ConsoleApp
{
    internal class LataDeOleo
    {
        public double altura;
        public double raio;

        public double calcularLataDeOleo()
        {
            double volume = (Math.PI * Math.Pow(raio, 2)) * altura;
            return volume;
        }
    }
}
