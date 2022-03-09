using System;

namespace Ex4.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro consumo = new Carro();
            consumo.kmInicial = 1200;
            consumo.kmFinal = 2300;
            consumo.qauntidadeLitros = 50;

            Console.WriteLine("O consumo de combustível por Km: " + Math.Round(consumo.calcularConsumoDeCombustivel(), 3));
            Console.ReadLine();
        }
    }
}
