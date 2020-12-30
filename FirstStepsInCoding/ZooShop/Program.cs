using System;

namespace ZooShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine());
            int animals = int.Parse(Console.ReadLine());
            double PriceFoodDogs = dogs * 2.50;
            int PriceFoodAnimals = animals * 4;
            double FullPrice = PriceFoodDogs + PriceFoodAnimals;

            Console.WriteLine($"{FullPrice} lv.");
        }
    }
}
