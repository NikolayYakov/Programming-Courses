using System;
using System.Linq;
namespace OddAndEvenSumDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArr = Console.ReadLine()
                             .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                             .Select(int.Parse)
                             .ToArray();
            int result = 0;
            int evenSum = 0;
            int oddSum = 0;
            for (int i = 0; i < numbersArr.Length; i++)
            {
                if (numbersArr[i] % 2 == 0)
                {
                    evenSum += numbersArr[i];
                }
                else
                {
                    oddSum += numbersArr[i];
                }
            }
            result = evenSum-oddSum;
            Console.WriteLine(result);
        }
    }
}
