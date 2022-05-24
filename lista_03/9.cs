using System;

namespace USCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 10 números: ");

            int[] arry = new int[10];
            int[] iguais = new int[10];
            int flag, a = 0;

            for (int i = 0; i < 10; ++i)
            {
                arry[i] = int.Parse(Console.ReadLine());
            }


            Console.Clear();

            Console.WriteLine("Todos os valores iguais:");
            int[] igual = new int[10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    flag = 0;

                    if (arry[i] == arry[j] && i != j)
                    {
                        for (int w = 0; w < 10; w++)
                            if (iguais[w] == arry[j])
                                flag = 1;

                        if (flag == 0)
                        {
                            iguais[a] = arry[i];
                            a++;
                        }
                    }
                }
            }

            for (int i = 0; i < a; i++)
                Console.Write($"| {iguais[i]} |");

            Console.ReadKey();
        }
    }
}
