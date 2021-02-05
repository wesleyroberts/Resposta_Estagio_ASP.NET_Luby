using System;

namespace atividade1
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a primeira data o formato dd/mm/yyyy");
            DateTime data = Convert.ToDateTime(Console.ReadLine()).Date;
            Console.WriteLine("Digite a segunda data o formato dd/mm/yyyy");
            DateTime data2 = Convert.ToDateTime(Console.ReadLine()).Date;
            Console.WriteLine(CalcularDiferencaData(data, data2));


            Console.ReadKey();
        }
        static int CalcularDiferencaData(DateTime data, DateTime data2)
        {
            int i = 0;
            if (data > data2)
            {
                TimeSpan t = data.Subtract(data2);
                i = (int)t.TotalDays;
            }
            if (data2 > data)
            {
                TimeSpan t1 = data2.Subtract(data);
                i = (int)t1.TotalDays;
            }

            return i;
        }
    }
}