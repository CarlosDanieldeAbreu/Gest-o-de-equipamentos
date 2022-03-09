using System;

namespace Ex3.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cilindro cilindro = new Cilindro();
            cilindro.altura = 12.78;
            cilindro.raio = 6.5;

            Console.WriteLine("O volume do cilindro é: " + Math.Round(cilindro.calcularCilindro(),2) + " Cm2");
            Console.ReadLine();
        }
    }
}
