using System;

namespace WorkingHourse
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            String day = Console.ReadLine();
            if (day == "Sunday")
            {
                Console.WriteLine("closed");
            }
            else
            {
                if (hour < 10)
                {
                    Console.WriteLine("closed");
                }
                else if (hour > 18)
                {
                    Console.WriteLine("closed");
                }
                else
                {
                    Console.WriteLine("open");
                }
            }
        }
    }
}
 
