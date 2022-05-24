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
                    Console.WriteLine("Erro: Valor negativo ou igual '0'!");
                    i--;
                }

            }

            Console.Clear();

            Console.WriteLine("Impares do array:");
            int[] numerosImpares = new int[i];

            for (i = 0; i < 10; i++)
            {
                if (numerosInteiros[i] % 2 != 0)
                {
                    numerosImpares[i] = numerosInteiros[i];
                    soma += numerosImpares[i];
                    Console.Write($"| {numerosImpares[i]} |");
                }
            }

            int media = soma / 10;

            Console.WriteLine($"\n\nMédia aritmetica de todos os números impares do array: {media}");

            Console.ReadKey();
        }
    }
}
