using System;

namespace FIne
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabsOpen = int.Parse(Console.ReadLine());
            double salary =int.Parse(Console.ReadLine());
            for(int i = 1; i <= tabsOpen; i++)
            {
                string tabs = Console.ReadLine();
                if(tabs=="Facebook")
                {
                    salary -= 150.0;
                }
               if(tabs=="Instagram")
                {
                    salary -= 100.0;
                }
               if(tabs=="Reddit")
                {
                    salary -= 50.0;
                }
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                     
                    break;
                }
                 
            }
            if (salary > 0)
            {
                Console.WriteLine($"{salary:f0}");
            }

        }
    }
}
