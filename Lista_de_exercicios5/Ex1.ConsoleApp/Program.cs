using System;

namespace Ex1.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaixaRetangular caixaRetangular = new CaixaRetangular();
            caixaRetangular.altura = 6;
            caixaRetangular.comprimento = 8;
            caixaRetangular.largura = 5;

            Console.WriteLine("O volume da caixa retangular é: " + caixaRetangular.CalcularVolumeRetangulo() + "Cm");
            Console.ReadLine();
        }
    }
}
