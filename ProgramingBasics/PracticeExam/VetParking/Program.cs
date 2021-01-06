using System;

namespace VetParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double price = 0.0;
            double dayTax = 0.0;
            for(int d = 1; d <= days; d++)
            {
                for(int h = 1; h <= hours; h++)
                {
                    if (d % 2 == 0 && h % 2 != 0)
                    {
                        price += 2.50;
                        dayTax += 2.50;
                    }
                    else if (d % 2 != 0 && h % 2 == 0)
                    {
                        price += 1.25;
                        dayTax += 1.25;
                    }
                    else
                    {
                        price += 1.00;
                        dayTax += 1.00;
                    }
                }
                Console.WriteLine($"Day: {d} - {dayTax:f2} leva");
                dayTax = 0;
            }
            Console.WriteLine($"Total: {price:f2} leva");
        }
    }
}
