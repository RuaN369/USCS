using System;
using System.Globalization;

namespace USCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] nota = new double[15];
            double soma = 0.0;

            for (int i = 0; i < 15; ++i)
            {
                nota[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                soma += nota[i];
            }

            soma /= 15;

            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
