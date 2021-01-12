using System;

namespace CookingMasterclass
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double flourPrice = double.Parse(Console.ReadLine());
            double eggPrice = double.Parse(Console.ReadLine());
            double apronPrice = double.Parse(Console.ReadLine());
            double apronsCount = Math.Ceiling(students * 1.20);
            double eggCount = students * 10;
            double price = 0;
            price += apronPrice * apronsCount;
            price += eggCount * eggPrice;
            for(int i = 1; i <= students; i++)
            {
                if (i % 5 != 0)
                {
                    price += flourPrice;
                }
            }

            if (price <= budget)
            {
                Console.WriteLine($"Items purchased for {price:f2}$.");
            }
            else
            {
                double needed = price - budget;
                Console.WriteLine($"{needed:f2}$ more needed.");
            }
        }
    }
}
