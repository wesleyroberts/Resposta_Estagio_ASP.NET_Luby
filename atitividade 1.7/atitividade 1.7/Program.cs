
using System;


namespace atividade1
{

    class Program
    {
        static void Main(string[] args)
        {

            int[] vetor = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(ObterElementosPares(vetor));


            Console.ReadKey();
        }
        static int[] ObterElementosPares(int[] vetor)
        {
            int a = vetor.Length;
            int[] vetor2;
            for (int i = 0; i < a; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    vetor[i] = vetor[i];
                }
            }
            return vetor;
        }

    }
}
