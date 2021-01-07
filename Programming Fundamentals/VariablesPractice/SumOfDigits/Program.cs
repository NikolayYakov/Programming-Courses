using System;

namespace SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int digits = number;
            int sum = 0;
            while (number > 0)
            {
                digits = number % 10;
                sum += digits;
                number /= 10;

            }
            Console.WriteLine(sum);
        }
    }
}
