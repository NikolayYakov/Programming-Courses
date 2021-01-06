using System;

namespace Mobile_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            string years = Console.ReadLine();
            string contractType = Console.ReadLine();
            string internet = Console.ReadLine();
            double mounths = double.Parse(Console.ReadLine());
            double price = 0.0;
            if (years == "one")
            {
                switch (contractType)
                {
                    case "Small":
                        price += 9.98;
                        break;
                    case "Middle":
                        price += 18.99;
                        break;
                    case "Large":
                        price += 25.98;
                        break;
                    case "ExtraLarge":
                        price += 35.99;
                        break;
                }
            }
            else if (years == "two")
            {
                switch (contractType)
                {
                    case "Small":
                        price += 8.58;
                        break;
                    case "Middle":
                        price += 17.09;
                        break;
                    case "Large":
                        price += 23.59;
                        break;
                    case "ExtraLarge":
                        price += 31.79;
                        break;
                }
            }
            if (internet == "yes")
            {
                if (price <= 10.00)
                {
                    price += 5.50;
                }
                else if (price <= 30.00)
                {
                    price += 4.35;
                }
                else
                {
                    price += 3.85;
                }
            }
            if (years == "two")
            {
                price *= 0.9625;
            }
            price *= mounths;
            Console.WriteLine($"{price:f2} lv.");
        }
    }
}
