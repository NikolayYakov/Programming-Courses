using System;

namespace DividedBy
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double dividedBy2 = 0.0;
            double dividedBy3 = 0.0;
            double dividedBy4 = 0.0;
            double counter = 0.0;
            for (int n = 1; n <= number; n++)
            {
                int realNumber = int.Parse(Console.ReadLine());
                counter += 1.0;
                if (realNumber % 2 == 0)
                {
                    dividedBy2 += 1.0;
                }
                if (realNumber % 3 == 0)
                {
                    dividedBy3 += 1.0;
                }
                if (realNumber % 4 == 0)
                {
                    dividedBy4 += 1.0;
                }
            }
            double dividedBy2Percent = dividedBy2 / counter * 100.0;
            double dividedBy3Percent = dividedBy3 / counter * 100.0;
            double dividedBy4Percent = dividedBy4 / counter * 100.0;
            Console.WriteLine($"{dividedBy2Percent:f2}%");
            Console.WriteLine($"{dividedBy3Percent:f2}%");
            Console.WriteLine($"{dividedBy4Percent:f2}%");
        }
    }
}
