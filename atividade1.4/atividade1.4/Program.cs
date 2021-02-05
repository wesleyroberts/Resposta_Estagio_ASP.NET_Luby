using System;


namespace atividade1
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um nome");
            string nome = Console.ReadLine();

            Console.WriteLine("A palavra digitada possui {0} vogais", CalcularVogais(nome));

            Console.ReadKey();
        }
        static int CalcularVogais(string nome)
        {
            int result = 0;
            Char[] arr = nome.ToCharArray();

            for (int i = 0; i < nome.Length; i++)
            {

                if (arr[i] == 'a')
                {
                    result++;
                }
                if (arr[i] == 'e')
                {
                    result++;
                }
                if (arr[i] == 'i')
                {
                    result++;
                }
                if (arr[i] == 'o')
                {
                    result++;
                }
                if (arr[i] == 'u')
                {
                    result++;
                }
            }
            return result;
        }
    }
}