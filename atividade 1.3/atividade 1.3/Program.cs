using System;

namespace atividade_1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe um numero");
            int num = int.Parse(Console.ReadLine());
            ContarNumerosPrimos(num);
        }

        static void ContarNumerosPrimos(int a)
        {
            {
                int result = 0;
                for (int i = 2; i < a; i++)
                {
                    
                    if(i== 2)
                    {
                        Console.WriteLine(i);
                        
                    }
                    else
                    {
                        if (i % 2 == 0)
                        {
                            continue;
                        }
                        else
                        {
                            bool isPrimo = true;
                            for (int j = 3; j < i / 2; j++)
                            {
                                if (i % j == 0)
                                {
                                    isPrimo = false;
                                    break;
                                }
                            }
                            result++;
                            if (isPrimo) Console.WriteLine(i);
                        }
                    }
                }
                Console.WriteLine("O numero total de numeros primos é: {0}" , result);
            }
        }
    }
}
