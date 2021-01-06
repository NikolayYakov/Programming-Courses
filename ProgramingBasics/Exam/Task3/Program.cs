using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            double hours = double.Parse(Console.ReadLine());
            double people = double.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            double price = 0.0;
             
            if(time == "day")
            {
                switch (month)
                {
                    case "march":
                    case "april":
                    case "may":
                        price = 10.50;
                        break;
                    case "june":
                    case "july":
                    case "august":
                        price = 12.60;
                        break;
                }
            }
            else if(time=="night")
            {
                switch (month)
                {
                    case "march":
                    case "april":
                    case "may":
                        price = 8.40;
                        break;
                    case "june":
                    case "july":
                    case "august":
                        price = 10.20;
                        break;
                }
            }
            if (people >= 4)
            {
                price *= 0.90;
            }
            if (hours >= 5)
            {
                price *= 0.50;
            }

            double totalPrice = price * people * hours;
            Console.WriteLine($"Price per person for one hour: {price:f2}");
            Console.WriteLine($"Total cost of the visit: {totalPrice:f2}");
            
        }
    }
}
