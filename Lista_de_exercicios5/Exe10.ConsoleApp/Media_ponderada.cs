using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe10.ConsoleApp
{
    internal class Media_ponderada
    {
        public double nota1;
        public double nota2;
        public double peso1;
        public double peso2;

        public double calcularMediaPonderada()
        {
            double mediaPonderada = (nota1 * peso1 + nota2 * peso2) / (peso1 + peso2); ;
            return mediaPonderada;
        }
    }
}
