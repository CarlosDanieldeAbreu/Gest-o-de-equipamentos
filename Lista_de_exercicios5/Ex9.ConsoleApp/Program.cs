using System;

namespace Ex9.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Media_harmonica mediaHarmonica = new Media_harmonica();
            mediaHarmonica.nota1 = 8.5;
            mediaHarmonica.nota2 = 9;
            mediaHarmonica.nota3 = 7.5;
            mediaHarmonica.nota4 = 9.5;

            Console.WriteLine("A média harmônica das notas é: {0}", Math.Round(mediaHarmonica.calcularMediaHarmonica(),2));
            Console.ReadLine();
        }
    }
}
