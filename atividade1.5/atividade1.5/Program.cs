using System;


namespace atividade1
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor total");
            Double valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a porcentagem de desconto");
            Double desconto = double.Parse(Console.ReadLine());

            Console.WriteLine("O valor final foi {0:c}", CalcularValorComDescontoFormatado(valor, desconto));

            Console.ReadKey();
        }
        static Double CalcularValorComDescontoFormatado(Double valor, Double desconto)
        {
            Double result = 0;
            result = (valor - (valor * (desconto / 100)));

            return result;
        }
    }
}
