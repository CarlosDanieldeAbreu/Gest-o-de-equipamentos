using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1.ConsoleApp
{
    public class CaixaRetangular
    {
        public decimal comprimento;
        public decimal largura;
        public decimal altura;

        public decimal CalcularVolumeRetangulo()
        {
            decimal volume = comprimento * largura * altura;
            return volume;
        }
    }
}
