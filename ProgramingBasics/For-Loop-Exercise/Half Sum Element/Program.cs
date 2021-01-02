using System;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int randomNumbers = int.Parse(Console.ReadLine());
            int result = 0;
            int maxNumber = int.MinValue;
            for(int i = 1; i <= randomNumbers; i++)
            {
                int number = int.Parse(Console.ReadLine());
                result += number;
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
            }
            result -= maxNumber;
            if (result == maxNumber)
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {result}");

            }
            else
            {
                int difference = result - maxNumber;
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(difference)}");
            }
        }
    }
}
