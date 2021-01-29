using System;
using System.Linq;

namespace Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Func<int[], int> smallestNumber = SmallNumber;
            Console.WriteLine(smallestNumber(numbers));
        }
        static int SmallNumber(int[] numbers)
        {
            int smallNumber = int.MaxValue;
            foreach (var number in numbers)
            {
                if (number < smallNumber)
                {
                    smallNumber = number;
                }
            }
            return smallNumber;
        }
    }
}
