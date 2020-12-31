using System;

namespace FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double strawberryPrice = double.Parse(Console.ReadLine());
            double bananasAmount = double.Parse(Console.ReadLine());
            double orangesAmount = double.Parse(Console.ReadLine());
            double raspberrysAmount = double.Parse(Console.ReadLine());
            double strawberrysAmount = double.Parse(Console.ReadLine());
            double raspberryPrice = strawberryPrice * 50 / 100;
            double orangePrice = raspberryPrice * 60 / 100;
            double bananaPrice = raspberryPrice * 20 / 100;
            double strewberrysFullPrice = strawberryPrice * strawberrysAmount;
            double bananasFullPrice = bananaPrice * bananasAmount;
            double raspberrysFullPrice = raspberryPrice * raspberrysAmount;
            double orangesFullPrice = orangesAmount * orangePrice;
            double moneyNeeded = strewberrysFullPrice + bananasFullPrice + raspberrysFullPrice + orangesFullPrice;
            Console.WriteLine($"{moneyNeeded:f2}");

        }
    }
}
