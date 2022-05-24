using System;
using System.Globalization;

namespace USCS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int N = 10;

            float[] hab = new float[N];
            float[] idade = new float[N];
            float[] altura = new float[N];

            float mediaIdadeF = 0, mediaIdadeM = 0, mediaAlturaF = 0, mediaAlturaM = 0;

            int contadorF = 0, contadorM = 0;

            for (int i = 0; i < N; ++i)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Digite: (0 - Feminino e 1 - Masculino)");

                int pesquisa = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.White;
                switch (pesquisa)
                {
                    case 0:
                        Console.WriteLine("Qual sua idade?");
                        idade[i] = float.Parse(Console.ReadLine());
                        Console.WriteLine("\nQual sua altura?\n");
                        altura[i] = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        mediaIdadeF += idade[i];
                        mediaAlturaF += altura[i];
                        contadorF++;

                        break;

                    case 1:
                        Console.WriteLine("Qual sua idade?");
                        idade[i] = float.Parse(Console.ReadLine());
                        Console.WriteLine("\nQual sua altura?\n");
                        altura[i] = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        mediaIdadeM += idade[i];
                        mediaAlturaM += altura[i];
                        contadorM++;

                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Erro: Valor não encontrado!");
                        --i;
                        break;
                }
            }

            // Medias
            mediaAlturaF /= contadorF;
            mediaIdadeF /= contadorF;

            mediaAlturaM /= contadorF;
            mediaIdadeM /= contadorF;

            float soma = 0;

            for (int i = 0; i < N; ++i)
            {
                soma += idade[i];
            }

            soma /= N;

            /*
            a)      média da idade do grupo;
            b)      média da altura das mulheres;
            c)      média da idade dos homens;
            d)      percentual de pessoas com idade entre 18 e 35 anos(inclusive).
            */

            Console.Clear();

            Console.WriteLine($"Media da altura das mulheres: {mediaAlturaF}");
            Console.WriteLine($"Media da altura dos homens: {mediaAlturaM}");

            Console.WriteLine($"Media da idade do grupo: {soma}");

            Console.WriteLine($"Media da idade das mulheres: {mediaIdadeF}");
            Console.WriteLine($"Media da idade dos homens: {mediaIdadeM}");


            Console.ReadKey();
        }
    }
}
