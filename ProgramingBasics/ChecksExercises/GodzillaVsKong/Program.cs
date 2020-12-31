using System;

namespace GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statistAmount = int.Parse(Console.ReadLine());
            double clothesPrice = double.Parse(Console.ReadLine());
            double decorPrice = budget * 10 / 100;
            double clothesFullPrice = statistAmount * clothesPrice;
            if (statistAmount > 150)
            {
                clothesFullPrice *= 0.9;
            }
            double movieFullPrice = clothesFullPrice + decorPrice;
            if (movieFullPrice <= budget)
            {
                double moneyLeft = budget - movieFullPrice;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");
            }
            else
            {
                double moneyNeeded = movieFullPrice - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {moneyNeeded:f2} leva more.");
            }
        }
    }
}
