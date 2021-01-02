using System;

namespace MinAndMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int randomNumbers = int.Parse(Console.ReadLine());
            int number = 0;
            int maxNumber = int.MinValue;
            int minNumber = int.MaxValue;
            for(int i = 0; i < randomNumbers; i += 1)
            {
                 number = int.Parse(Console.ReadLine());
                if (maxNumber < number)
                {
                    maxNumber = number;
                }
                if (minNumber > number)
                {
                    minNumber = number;
                }
            }
            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
        }
    }
}
