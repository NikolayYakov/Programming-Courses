using System;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double amount =double.Parse(Console.ReadLine());
            double Price = 0.0;
             
            
            if (city == "Sofia")
            {
                switch (product)
                {
                    case "coffee":
                        Price = amount * 0.50;
                        break;
                    case "water":
                        Price = amount * 0.80;
                        break;
                    case "beer":
                        Price = amount * 1.20;
                        break;
                    case "sweets":
                        Price = amount * 1.45;
                        break;
                    case "peanuts":
                        Price = amount * 1.60;
                        break;



                }


            }
            else if (city == "Plovdiv")
            {
                switch (product)
                {
                    case "coffee":
                        Price = amount * 0.40;
                        break;
                    case "water":
                        Price = amount * 0.70;
                        break;
                    case "beer":
                        Price = amount * 1.15;
                        break;
                    case "sweets":
                        Price = amount * 1.30;
                        break;
                    case "peanuts":
                        Price = amount * 1.50;
                        break;



                }
            }
            else
            {
                switch (product)
                {
                    case "coffee":
                        Price = amount * 0.45;
                        break;
                    case "water":
                        Price = amount * 0.70;
                        break;
                    case "beer":
                        Price = amount * 1.10;
                        break;
                    case "sweets":
                        Price = amount * 1.35;
                        break;
                    case "peanuts":
                        Price = amount * 1.55;
                        break;



                }
            }
            Console.WriteLine(Price);
        }
    }
}
