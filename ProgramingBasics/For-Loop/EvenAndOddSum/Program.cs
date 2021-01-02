using System;

namespace EvenAndOddSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int randomNumbers = int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;
            for(int i = 1; i <= randomNumbers; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += number;
                }
                else
                {
                    oddSum += number;
                }
            }
            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {evenSum}");
            }
            else
            {
                int difference = evenSum - oddSum;
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(difference)}");
            }
        }
    }
}
