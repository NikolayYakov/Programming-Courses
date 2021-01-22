using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_and_Dictionaries_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Dictionary<double, int> numberCount = new Dictionary<double, int>();
            for(int i = 0; i < numbers.Length; i++)
            {
                if (!numberCount.ContainsKey(numbers[i]))
                {
                    numberCount.Add(numbers[i], 0);
                }
                numberCount[numbers[i]]++;
            }
            foreach (var number in numberCount)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times");
            }
        }
    }
}
