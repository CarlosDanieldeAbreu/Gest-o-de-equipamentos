using System;

namespace Ex7.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SalarioFuncionario salario = new SalarioFuncionario();
            salario.salarioBase = 1500;
            salario.totalDeVendas = 35000;
            salario.percentual = 25;

            Console.WriteLine("O salário total de um vendedor é: {0} R$", salario.calcularSalarioFinal());
            Console.ReadLine();
        }
    }
}
