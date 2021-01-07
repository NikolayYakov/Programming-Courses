using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int beerKentAmount = int.Parse(Console.ReadLine());
            var biggestVolume = 0.0;
            string biggestModel = string.Empty;
            for (int i = 1; i<= beerKentAmount; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                var volume = Math.PI * radius * radius * height;
                if (volume > biggestVolume)
                {
                    biggestVolume = volume;
                    biggestModel = model;
                }

            }
            Console.WriteLine(biggestModel);
        }
    }
}
