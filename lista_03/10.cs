using System;

namespace USCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 10 números: ");

            int[] arry1 = new int[10];

            for (int i = 0; i < 10; ++i)
            {
                Console.ForegroundColor = ConsoleColor.White;
                arry1[i] = int.Parse(Console.ReadLine());

                if (arry1[i] <= 0)
                {
                    arry1[i] = 0;
                }
            }

            Console.ReadKey();
        }
    }
}
