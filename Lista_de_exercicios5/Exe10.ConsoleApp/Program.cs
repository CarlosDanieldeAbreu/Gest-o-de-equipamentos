using System;

namespace Exe10.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Media_ponderada ponderada = new Media_ponderada();
            ponderada.nota1 = 9;
            ponderada.nota2 = 7.5;
            ponderada.peso1 = 3;
            ponderada.peso2 = 4;

            Console.WriteLine("A média ponderada de duas provas realizadas por um aluno é: {0}", Math.Round(ponderada.calcularMediaPonderada(),2));
            Console.ReadLine();
        }
    }
}
