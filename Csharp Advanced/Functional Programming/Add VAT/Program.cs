using System;
using System.Linq;

namespace Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] prices = Console.ReadLine()
                                     .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                     .Select(double.Parse)
                                     .Select(n => n + (n * 0.20))
                                     .ToArray();
            foreach (var item in prices)
            {
                Console.WriteLine($"{item:f2}");
            }
        }
    }
}
