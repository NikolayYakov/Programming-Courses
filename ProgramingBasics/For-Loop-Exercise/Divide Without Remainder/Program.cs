using System;

namespace Divide_Without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            double randomNumber = int.Parse(Console.ReadLine());
            double dividedBy2 = 0.0;
            double dividedBy3 = 0.0;
            double dividedBy4 = 0.0;
            for(int i = 1; i <= randomNumber; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    dividedBy2 += 1;
                }
                if (number % 3 == 0)
                {
                    dividedBy3 += 1;
                }
               if (number % 4 == 0)
                {
                    dividedBy4 += 1;
                }
            }
            randomNumber /= 100.0;
            double dividedBy2Percent = dividedBy2 / randomNumber;
            double dividedBy3Percent = dividedBy3 /randomNumber;
            double dividedBy4Percent = dividedBy4 / randomNumber;
            Console.WriteLine($"{dividedBy2Percent:f2}%");
            Console.WriteLine($"{dividedBy3Percent:f2}%");
            Console.WriteLine($"{dividedBy4Percent:f2}%");



        }
    }
}
