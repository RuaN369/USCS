using System;

namespace USCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arry = new int[6];

            for (int i = 0; i < 6; ++i)
            {
                arry[i] = int.Parse(Console.ReadLine());
            }

            Console.Clear();

            for (int i = 5; i >= 0; --i)
            {
                Console.WriteLine(arry[i]);
            }

            Console.ReadKey();
        }
    }
}
