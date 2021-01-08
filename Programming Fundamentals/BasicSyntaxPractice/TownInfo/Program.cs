using System;

namespace TownInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string cityName = Console.ReadLine();
            int popilation = int.Parse(Console.ReadLine());
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine($"Town {cityName} has population of {popilation} and area {size} square km.");
        }
    }
}
