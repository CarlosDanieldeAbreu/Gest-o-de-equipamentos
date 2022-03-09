using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4.ConsoleApp
{
    public class Carro
    {
        public double kmInicial;
        public double kmFinal;
        public double qauntidadeLitros;

        public double calcularConsumoDeCombustivel()
        {
            double gastoPorKm = (kmFinal - kmInicial) / qauntidadeLitros;
            return gastoPorKm;
        }
    }
}
