using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = int.Parse(Console.ReadLine());
            var peopleType = Console.ReadLine();
            var day = Console.ReadLine();
            var totalPrice = 0.0;
            var price = 0.0;
            switch (day)
            {
                case "Friday":
                    if (peopleType == "Students")
                    {
                        price = 8.45;
                    }
                    else if (peopleType == "Business")
                    {
                        price = 10.90;
                    }
                    else
                    {
                        price = 15;
                    }
                    break;
                case "Saturday":
                    if (peopleType == "Students")
                    {
                        price = 9.80;
                    }
                    else if (peopleType == "Business")
                    {
                        price = 15.60;
                    }
                    else
                    {
                        price = 20;
                    }
                    break;
                case "Sunday":
                    if (peopleType == "Students")
                    {
                        price = 10.46;
                    }
                    else if (peopleType == "Business")
                    {
                        price = 16;
                    }
                    else
                    {
                        price = 22.50;
                    }
                    break;

            }
            totalPrice = price * people;
            if(peopleType== "Students" && people >= 30)
            {
                totalPrice *= 0.85;
            }
            if (peopleType == "Regular" && people >= 10 && people <= 20)
            {
                totalPrice *= 0.95;
            }
            if(peopleType== "Business" && people >= 100)
            {
                people -= 10;
                totalPrice = people * price;
            }
            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
