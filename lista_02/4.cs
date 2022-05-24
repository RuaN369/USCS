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

                if (numerosInteiros[i] < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Erro: Valor negativo ou igual '0'!");
                    i--;
                }

            }

            Console.Clear();

            Console.WriteLine("Notas:");

            for (i = 0; i < 10; i++)
            {
                Console.Write($"| {numerosInteiros[i]} |");
                soma += numerosInteiros[i];
            }

            soma /= 10;

            Console.WriteLine($"\n\nMedia: {soma}");

            Console.ReadKey();
        }
    }
}
