using System;

namespace NumbersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            if (number <= 100)
            {
                if(number >= -100)
                {
                    if (number != 0)
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No");
                    }
                }
                else
                {
                    Console.WriteLine("No");
                }

            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
