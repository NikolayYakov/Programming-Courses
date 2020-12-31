using System;

namespace Gardening
{
    class Program
    {
        static void Main(string[] args)
        {
            double SquareMeters = double.Parse(Console.ReadLine());
            double FullPrice = SquareMeters * 7.61;
            double discount = FullPrice * 18/100;
            double DiscountedPrice = FullPrice - discount;
            Console.WriteLine($"The final price is: {DiscountedPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
       
        }
    }
}
