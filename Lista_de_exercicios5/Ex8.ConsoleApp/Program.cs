using System;

namespace Ex8.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LataDeOleo lata = new LataDeOleo();
            lata.altura = 5;
            lata.raio = 3;

            Console.WriteLine("O volume da lata de óleo é: " + Math.Round(lata.calcularLataDeOleo(), 2) + " Cm2");
            Console.ReadLine();
        }
    }
}
