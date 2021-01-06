using System;

namespace FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            double chicken = double.Parse(Console.ReadLine());
            double fish = double.Parse(Console.ReadLine());
            double vega = double.Parse(Console.ReadLine());
            double fullPrice = chicken * 10.35 + fish * 12.40 + vega * 8.15;
            fullPrice *= 1.20;
            fullPrice += 2.50;
            Console.WriteLine($"Total: {fullPrice:f2}");
        }
    }
}
