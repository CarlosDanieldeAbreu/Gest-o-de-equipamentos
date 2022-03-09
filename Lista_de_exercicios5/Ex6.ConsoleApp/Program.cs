using System;

namespace Ex6.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConversorDeTemperatura2 conversorDeTemperatura = new ConversorDeTemperatura2();
            conversorDeTemperatura.celcius = 100.98m;
            Console.WriteLine("A temperatura de graus Celsius(" + conversorDeTemperatura.celcius + "°C) para graus Fahrenheit é: " + Math.Round(conversorDeTemperatura.calcularTemperatura(), 2) + "°F");
            Console.ReadLine();
        }
    }
}
