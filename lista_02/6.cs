using System;

namespace USCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 10 números inteiros e maiores que zero: ");

            int[] arry1 = new int[10];
            int i;

            for (i = 0; i < 10; ++i)
            {
                Console.ForegroundColor = ConsoleColor.White;
                arry1[i] = int.Parse(Console.ReadLine());

                if (arry1[i] <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Erro: Valor negativo ou igual '0'!");
                    i--;
                }
            }

            Console.WriteLine("\n\nDigite novamente mais 10 números inteiros e maiores que zero: ");

            int[] arry2 = new int[10];

            for (i = 0; i < 10; ++i)
            {
                Console.ForegroundColor = ConsoleColor.White;
                arry2[i] = int.Parse(Console.ReadLine());

                if (arry2[i] <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Erro: Valor negativo ou igual '0'!");
                    i--;
                }
            }

            Console.Clear();
            Console.WriteLine("Arry 1 :");

            for (i = 0; i < 10; ++i)

                Console.Write($"| {arry1[i]} |");

            Console.WriteLine("\n\nArry 2 :");

            for (i = 0; i < 10; ++i)

                Console.Write($"| {arry2[i]} |");

            Console.WriteLine("\n\nTodos os valores que fazem parte (estão presentes) nos dois arrays:");


            bool igual = false;

            for (i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (arry1[i] == arry2[j])
                        igual = true;
                }
                if (igual == false)
                    Console.Write($"| {arry1[i]} |");
            }

            Console.ReadKey();
        }
    }
}
