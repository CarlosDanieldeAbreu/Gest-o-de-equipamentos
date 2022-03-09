using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3.ConsoleApp
{
    public class Cilindro
    {
        public double altura;
        public double raio;

        public double calcularCilindro()
        {
            double volume = (Math.PI * raio * raio) * altura;
            return volume;
        }
    }
}
