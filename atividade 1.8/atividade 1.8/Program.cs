
using System;
using System.Linq;

namespace atividade1
{
    class Program
    {

        static void Main(string[] args)
        {

            string[] vetor = new string[] {
    "John Doe",
    "Jane Doe",
    "Alice Jones",
    "Bobby Louis",
    "Lisa Romero"
};
            BuscarPessoa(vetor);
            Console.ReadKey();
        }
        static void BuscarPessoa(string[] vetor)
        {
            Console.WriteLine("insira um nome de busca:");
            string nome = Console.ReadLine();
            string[] array2 = { };
            int result = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                char[] delimitador = { ' ' };
                string frase = vetor[i];
                string[] separado = frase.Split(delimitador);
                for (int j = 0; j < separado.Length; j++)
                {
                    if (nome == separado[j])
                    {
                        result++;
                        array2 = frase.Split(',');
                        foreach (Object z in array2)
                        {
                            Console.WriteLine("{0}", z);
                        }
                    }
                }
                if (result == 0)
                {
                    Console.WriteLine("Nome não encontrado");
                }
            }


        }
    }
}