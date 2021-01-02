using System;

namespace Odd___Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int randomNumbers = int.Parse(Console.ReadLine());
            double oddSum = 0.0;
            double oddMax = int.MinValue;
            double oddMin = int.MaxValue;
            double evenSum = 0.0;
            double evenMax = int.MinValue;
            double evenMin = int.MaxValue;
            for (int i = 1; i <= randomNumbers; i++)

            {
                double number = double.Parse(Console.ReadLine());
                if (i % 2 != 0)
                {
                    oddSum += number;
                    if (number > oddMax)
                    {
                        oddMax= number;
                    }
                    if (number < oddMin)
                    {
                        oddMin=number;
                    }

                }
                if (i % 2 == 0)
                {
                    evenSum += number;
                    if (number > evenMax)
                    {
                        evenMax = number;
                    }
                    if (number < evenMin)
                    {
                        evenMin = number;
                    }
                }
            }
            Console.WriteLine($"OddSum={oddSum:f2},");
            if (randomNumbers == 0)
            { 
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={oddMin:f2},");
                Console.WriteLine($"OddMax={oddMax:f2},");
            }
            Console.WriteLine($"EvenSum={evenSum:f2},");
            if (randomNumbers == 0)
            {
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else if (randomNumbers == 1)
            {
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMin={evenMin:f2},");
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }
        }
    }
}
