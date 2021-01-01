using System;

namespace Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayOfTheWeek = int.Parse(Console.ReadLine());
            if (dayOfTheWeek >= 1)
            {
                if (dayOfTheWeek <= 7)
                {
                    if (dayOfTheWeek == 1)
                    {
                        Console.WriteLine("Monday");
                    }
                    else if (dayOfTheWeek == 2)
                    {
                        Console.WriteLine("Tuesday");
                    }
                    else if (dayOfTheWeek == 3)
                    {
                        Console.WriteLine("Wednesday");

                    }
                    else if (dayOfTheWeek == 4)
                    {
                        Console.WriteLine("Thursday");
                    }
                    else if (dayOfTheWeek == 5)
                    {
                        Console.WriteLine("Friday");

                    }
                    else if (dayOfTheWeek == 6)
                    {
                        Console.WriteLine("Saturday");

                    }
                    else if (dayOfTheWeek == 7)
                    {
                        Console.WriteLine("Sunday");

                    }
                     
                }

            }
            if (dayOfTheWeek < 1)
            {
                Console.WriteLine("Error");
            }
            if (dayOfTheWeek > 7)
            {
                Console.WriteLine("Error");

            }

        }
    }
}
