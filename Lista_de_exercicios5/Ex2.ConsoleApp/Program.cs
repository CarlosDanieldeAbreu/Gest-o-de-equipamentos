using System;

namespace Ex2.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConversorDeTemperatura conversorDeTemperatura = new ConversorDeTemperatura();
            conversorDeTemperatura.fahrenheit = 100.98m;
            Console.WriteLine("A temperatura de graus Fahrenheit(" + conversorDeTemperatura.fahrenheit + "°F) para graus Celsius é: " + Math.Round(conversorDeTemperatura.calcularTemperatura(),2) + "°C");
            Console.ReadLine();
        }
    }
}
