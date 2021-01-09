using System;
using System.Linq;
namespace RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numberArr = Console.ReadLine()
                              .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                              .Select(double.Parse)
                              .ToArray();
            for(int i = 0; i < numberArr.Length; i++)
            {
                double number = numberArr[i];
                double roundedeNumber = Math.Round(number, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{Convert.ToDecimal(number)} => {Convert.ToDecimal(roundedeNumber)}");




            }
        }
    }
}
