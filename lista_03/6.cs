using System;

namespace USCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arry = new int[8];

            for (int i = 0; i < 8; ++i)
            {
                arry[i] = int.Parse(Console.ReadLine());
            }

            Console.Clear();

            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            arry[0] = x;
            arry[7] = y;

            int soma = x + y;

            Console.Clear();

            Console.WriteLine($"Soma dos valores encontrados nas respectivas posições X e Y:\n{soma}");

            Console.ReadKey();
        }
    }
}
