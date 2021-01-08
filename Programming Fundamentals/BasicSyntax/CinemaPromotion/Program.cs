using System;

namespace CinemaPromotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string time = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            var price = 0;
            switch (time)
            {
                case "Weekday":
                    if (age >= 0 && age <= 18)
                    {
                        price = 12;
                        Console.WriteLine($"{price}$");
                    }
                    else if (age < 0 || age > 122)
                    {
                        Console.WriteLine("Error!");
                    }
                    else if (age <= 64)
                    {
                        price = 18;
                        Console.WriteLine($"{price}$");

                    }
                    else if (age <= 122)
                    {
                        price = 12;
                        Console.WriteLine($"{price}$");

                    }
                    
                    break;
                case "Weekend":
                    if (age >= 0 && age <= 18)
                    {
                        price = 15;
                        Console.WriteLine($"{price}$");
                    }
                    else if (age < 0 || age > 122)
                    {
                        Console.WriteLine("Error!");
                    }
                    else if (age <= 64)
                    {
                        price = 20;
                        Console.WriteLine($"{price}$");

                    }
                    else if (age <= 122)
                    {
                        price = 15;
                        Console.WriteLine($"{price}$");

                    }
                    
                    break;
                case "Holiday":
                    if (age >= 0 && age <= 18)
                    {
                        price = 5;
                        Console.WriteLine($"{price}$");
                    }
                    else if (age < 0 || age > 122)
                    {
                        Console.WriteLine("Error!");
                    }
                    else if (age <= 64)
                    {
                        price = 12;
                        Console.WriteLine($"{price}$");

                    }
                    else if (age <= 122)
                    {
                        price = 10;
                        Console.WriteLine($"{price}$");

                    }
                    
                    break;
            }
        }
    }
}
