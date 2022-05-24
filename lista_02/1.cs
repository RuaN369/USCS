using System;

namespace USCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 10 números inteiros e maiores que zero: ");

            int[] numerosInteiros = new int[10];
            int i;

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
            Console.WriteLine("Arry 1 (Todos os numeros):");

            for (i = 0; i < 10; ++i)
            {
                Console.Write($"| {numerosInteiros[i]} |");
            }

            Console.WriteLine("\n\nArry 2(Pares):");
            int[] numerosPares = new int[i];

            for (i = 0; i < 10; i++)
            {
                if (numerosInteiros[i] % 2 == 0)
                {
                    numerosPares[i] = numerosInteiros[i];
                    Console.Write($"| {numerosPares[i]} |");
                }
            }

            Console.WriteLine("\n\nArry 3(Impares):");
            int[] numerosImpares = new int[i];

            for (i = 0; i < 10; i++)
            {
                if (numerosInteiros[i] % 2 != 0)
                {
                    numerosImpares[i] = numerosInteiros[i];
                    Console.Write($"| {numerosImpares[i]} |");
                }
            }

            Console.ReadKey();
        }
    }
}
