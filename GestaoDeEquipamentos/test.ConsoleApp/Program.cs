using System;

namespace test.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string strDataAbertura = "20/02/2001";
            DateTime abertura = DateTime.Parse(strDataAbertura);
            TimeSpan diferenca = DateTime.Today - abertura;
            double dias = diferenca.TotalDays;

            Console.WriteLine(abertura);
            Console.ReadKey();
        }
    }
}
