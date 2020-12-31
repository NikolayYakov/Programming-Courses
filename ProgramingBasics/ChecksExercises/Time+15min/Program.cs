using System;

namespace Time_15min
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes += 15;
            if (hours > 23)
            {
                hours = 0;
            }
            if (minutes < 60)
            {
                if (minutes >= 10)
                {
                    Console.WriteLine($"{hours}:{minutes}");
                }
                else
                {
                    Console.WriteLine($"{hours}:0{minutes}");
                }
            }
            else
            {
                hours += 1;
                minutes -= 60;
                if (hours > 23)
                {
                    hours = 0;
                }
                if (minutes >= 10)
                {
                    Console.WriteLine($"{hours}:{minutes}");
                }
                else
                {
                    Console.WriteLine($"{hours}:0{minutes}");
                }
            }

        }
    }
}
