using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            double randomNumber = int.Parse(Console.ReadLine());
            int under200 = 0;
            int between200And400 = 0;
            int between400And600 = 0;
            int between600And800 = 0;
            int biggerThan800 = 0;

            for (int i = 1; i <= randomNumber; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 200)
                {
                    under200 += 1;
                }
                else if (number < 400)
                {
                    between200And400 += 1;
                }
                else if (number < 600)
                {
                    between400And600 += 1;
                }
                else if (number < 800) 
                {
                    between600And800 += 1;
                }
                else
                {
                    biggerThan800 += 1;
                }
            }
            randomNumber /= 100.0;
            double under200Percent = under200 / randomNumber;
            double between200And400Percent = between200And400 / randomNumber;
            double between400And600Percent = between400And600 / randomNumber;
            double between600And800Percent = between600And800 / randomNumber;
            double biggerThan800Percent = biggerThan800 / randomNumber;
            Console.WriteLine($"{under200Percent:f2}%");
            Console.WriteLine($"{between200And400Percent:f2}%");
            Console.WriteLine($"{between400And600Percent:f2}%");
            Console.WriteLine($"{between600And800Percent:f2}%");
            Console.WriteLine($"{biggerThan800Percent:f2}%");
        }
    }
}
