using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projectionType = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            double fullProfit = 0.0;
            switch (projectionType)
            {
                case "Premiere":
                    fullProfit = rows * columns * 12.00;
                    break;
                case "Normal":
                    fullProfit = rows * columns * 7.50;
                    break;
                case "Discount":
                    fullProfit = rows * columns * 5.00;
                    break;
            }
            Console.WriteLine($"{fullProfit:f2}");
        }
    }
}
