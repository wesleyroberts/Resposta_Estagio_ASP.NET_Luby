using System;


namespace atividade1
{

    class Program
    {
        static void Main(string[] args)
        {
            function();

            Console.ReadKey();
        }
        static void function()
        {
            Console.WriteLine("Digite o valor do premio!");
            Double valor = double.Parse(Console.ReadLine());
            Console.WriteLine(valor);
            Console.WriteLine("Digite o numero correspondente ao tipo do premio!");
            Console.WriteLine("1-[ Basico ] \t 2-[Vip] \t 3-[Premium] \t 4-[Deluxe] \t 5-[Special]");
            int tipo = int.Parse(Console.ReadLine());
        multiplicador:
            Console.WriteLine("Digite o mutiplicador do prêmio");
            string multiplicador = Console.ReadLine();

            int mult = 0;

            if (multiplicador == null)
            {
                mult = 1;

            }
            mult = int.Parse(multiplicador);

            if (mult < 0)
            {
                Console.WriteLine("Numero negativo não é valido, porfavor colocar um valor maior que zero ou nenhum valor");
                goto multiplicador;
            }
            Double result = 0;
            if (tipo == 1)
            {
                result = valor * 1 * mult;
            }
            if (tipo == 2)
            {
                result = valor * 1.2 * mult; ;
            }
            if (tipo == 3)
            {
                result = valor * 1.5 * mult; ;
            }
            if (tipo == 4)
            {
                result = valor * 1.8 * mult; ;
            }
            if (tipo == 5)
            {
                result = valor * 2 * mult; ;
            }
            Console.WriteLine(result);
        }
    }
}a