using System;

namespace USCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 10 números:");

            double[] arry = new double[10];
            for (int i = 0; i < 10; ++i)
            {
                arry[i] = double.Parse(Console.ReadLine());
            }

            Console.Clear();
            Console.WriteLine("Valores negativos:");

            double soma = 0;

            for (int i = 0; i < 10; ++i)
            {
                if (arry[i] < 0)
                {
                    Console.Write($"| {arry[i]} |");
                    soma += arry[i];
                }
            }

            double media = soma / 10.0;

            Console.WriteLine($"\nMédia dos valores menores que zero:\n{media}");

            Console.ReadKey();
        }
    }
}
