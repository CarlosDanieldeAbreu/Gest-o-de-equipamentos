using System;

namespace Ex5.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Esfera esfera = new Esfera();
            esfera.raio = 3;

            Console.WriteLine("O volume de uma esfera é: " + esfera.raio + " Cm3");
            Console.ReadLine();
        }
    }
}
