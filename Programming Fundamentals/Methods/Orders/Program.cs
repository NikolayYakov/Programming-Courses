using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quontity = int.Parse(Console.ReadLine());
            TotalPrice(product, quontity);
 
        }
        static void TotalPrice(string product,int quontity)
        {
            decimal totalPrice = 0M;
            switch (product)
            {
                case "coffee":
                    totalPrice += 1.50M;
                    break;
                case "water":
                    totalPrice += 1.00M;
                    break;
                case "coke":
                    totalPrice += 1.40M;
                    break;
                case "snacks":
                    totalPrice += 2.00M;
                    break;
            }
            totalPrice *= quontity;
            Console.WriteLine($"{totalPrice:f2}");
        }
        
    }
}
