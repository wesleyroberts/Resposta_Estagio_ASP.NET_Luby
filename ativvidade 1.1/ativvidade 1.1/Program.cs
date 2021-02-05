
using System;

namespace atividade1
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor!");
            int valor = int.Parse(Console.ReadLine());
            Console.WriteLine(calc(valor));
            Console.ReadKey();
        }
        static int calc(int a)
        {
            return ((a <= 1) ? 1 : (a * calc(a - 1)));
        }
    }
}