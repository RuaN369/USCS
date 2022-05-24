using System;

namespace USCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 10 números inteiros e maiores que zero: ");

            int[] numerosInteiros = new int[10];
            int i, soma = 0;

            for (i = 0; i < 10; ++i)
            {
                Console.ForegroundColor = ConsoleColor.White;
                numerosInteiros[i] = int.Parse(Console.ReadLine());

                if (numerosInteiros[i] <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Erro: Valor negativo!");
                    i--;
                }

            }

            Console.Clear();

            Console.WriteLine("Pares do array:");
            int[] numerosPares = new int[i];

            for (i = 0; i < 10; i++)
            {
                if (numerosInteiros[i] % 2 == 0)
                {
                    numerosPares[i] = numerosInteiros[i];
                    soma += numerosPares[i];
                    Console.Write($"| {numerosPares[i]} |");
                }
            }

            Console.WriteLine($"\n\nSoma dos pares do array: {soma}");

            Console.ReadKey();
        }
    }
}
