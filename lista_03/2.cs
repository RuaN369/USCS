using System;

namespace USCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double soma = 0;

            Console.WriteLine("Digite o valor pago:");

            double[] dinheiro = new double[150];
            for (int i = 0; i < 150; ++i)
            {
                Console.Write("R$ ");
                dinheiro[i] = int.Parse(Console.ReadLine());

                if (dinheiro[i] < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Erro: Valor negativo ou igual '0'!");
                    i--;
                }

                soma += dinheiro[i];
            }

            Console.WriteLine("Receita total: R$ {0}", soma.ToString("F2"));

            Console.ReadKey();
        }
    }
}
