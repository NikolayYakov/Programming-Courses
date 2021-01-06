using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
             
            int counterDays = 1;
            int counterMeters = 5364;
            while (true)
            {
                string day = Console.ReadLine();
                if (day == "END")
                {
                    Console.WriteLine("Failed!");
                    Console.WriteLine($"{counterMeters}");
                    break;
                }
                if (day == "Yes")
                {
                    counterDays++;
                }
                
                int meters =int.Parse(Console.ReadLine());
                counterMeters += meters;
                if(counterMeters >= 8848)
                {
                    Console.WriteLine($"Goal reached for {counterDays} days!");
                    break;
                }
                if (counterDays > 5)
                {
                    counterMeters -= meters;
                    Console.WriteLine("Failed!");
                    Console.WriteLine($"{counterMeters}");
                    break;
                }
            }
        }
    }
}
