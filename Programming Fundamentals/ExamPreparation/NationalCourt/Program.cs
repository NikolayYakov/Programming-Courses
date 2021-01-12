using System;

namespace NationalCourt
{
    class Program
    {
        static void Main(string[] args)
        {
            int efficiency = 0;
            for (int i = 0; i < 3; i++)
            {
                int employeeEfficiency = int.Parse(Console.ReadLine());
                efficiency += employeeEfficiency;
            }
            int people = int.Parse(Console.ReadLine());
            int hours = 0;
            while (people != 0)
            {
                if (people >= efficiency)
                {
                    hours += 1;
                    people -= efficiency;
                }
                else
                {
                    hours += 1;
                    people = 0;
                }
                if (hours % 4 == 0)
                {
                    hours += 1;
                }
            }
            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
