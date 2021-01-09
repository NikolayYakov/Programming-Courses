using System;
using System.Linq;
namespace SumOfEvenNumbers
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
            for(int i = 0; i < numbersArr.Length; i++)
            {
                if (numbersArr[i] % 2 == 0)
                {
                    result += numbersArr[i];
                }
            }
            Console.WriteLine(result);
        }
    }
}
