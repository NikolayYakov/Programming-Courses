using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string opinion = Console.ReadLine();
            double price = 0.0;
            days -= 1;
            switch (roomType)
            {
                case "room for one person":
                    price = days * 18.00;
                    break;
                case "apartment":
                    price = days * 25.00;
                    if (days < 10)
                    {
                        price *= 0.7;
                    }
                    else if (days <= 15)
                    {
                        price *= 0.65;
                    }
                    else
                    {
                        price *= 0.50;
                    }
                    break;
                case "president apartment":
                    price = days * 35.00;
                    if (days < 10)
                    {
                        price *= 0.9;
                    }
                    else if (days <= 15)
                    {
                        price *= 0.85;
                    }
                    else
                    {
                        price *= 0.80;
                    }
                    break;

            }
            if(opinion== "positive")
            {
                price *= 1.25;
            }
            else
            {
                price *= 0.90;
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
