using System;
using System.Linq;

namespace TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int targetSum = int.Parse(Console.ReadLine());
            string[] words = Console.ReadLine().Split(" ");
            Func<string, int, bool> isValid = (str, num) => str.ToCharArray().Select(ch => (int)ch).Sum() >= num;
            Func<string[], int, Func<string, int, bool>, string> firstValidName = (arr, num, func) => arr.FirstOrDefault(str => func(str, num));
            var result = firstValidName(words, targetSum, isValid);
            Console.WriteLine(result);
        }
    }
}
