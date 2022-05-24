using System;

namespace USCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Digite quantos votos seram informados através de código: ");

            Console.ForegroundColor = ConsoleColor.White;
            int N = int.Parse(Console.ReadLine());

            Console.Clear();

            int[] cantidadoUm = new int[N];
            int[] cantidadoDois = new int[N];
            int[] branco = new int[N];
            int[] nulo = new int[N];

            int votoU = 0, votoD = 0, votoT = 0, votoQ = 0;


            for (int i = 0; i < N; ++i)
            {
                Console.WriteLine("Digite 1 para o candidato 1, 2 para o candidato 2, 3 para branco e 4 nulo");

                int voto = int.Parse(Console.ReadLine());

                switch (voto)
                {
                    case 1:
                        votoU += 1;
                        break;
                    case 2:
                        votoD += 1;
                        break;
                    case 3:
                        votoT += 1;
                        break;
                    case 4:
                        votoQ += 1;
                        break;
                    default:
                        Console.WriteLine("Erro: Valor não encontrado!");
                        --i;
                        break;
                }
            }

            Console.Clear();

            Console.WriteLine($"Total de votos para o cada candidato 1: {votoU}");
            Console.WriteLine($"Total de votos para o cada candidato 2: {votoD}");
            Console.WriteLine($"Total de votos brancos: {votoT}");
            Console.WriteLine($"Total de votos nulos: {votoQ}");
            Console.WriteLine($"Total de votos lidos: {N}");

            if (votoU > votoD)
            {
                Console.WriteLine("\nCandidato 1 foi o vencedor!");
            }
            else
            {
                Console.WriteLine("\nCandidato 2 foi o vencedor!");
            }

            Console.ReadKey();
        }
    }
}
