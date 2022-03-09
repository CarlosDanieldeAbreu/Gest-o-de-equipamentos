using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7.ConsoleApp
{
    public class SalarioFuncionario
    {
        public decimal salarioBase;
        public decimal totalDeVendas;
        public decimal percentual;

        public decimal calcularComissao()
        {
            decimal comissao = totalDeVendas * (percentual / 100);
            return comissao;
        }

        public decimal calcularSalarioFinal()
        {
            decimal salarioFinal = salarioBase + calcularComissao();
            return salarioFinal;
        }
    }
}
