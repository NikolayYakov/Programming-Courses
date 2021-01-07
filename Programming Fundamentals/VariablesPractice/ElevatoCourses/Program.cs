using System;

namespace ElevatoCourses
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());
            int courses = 0;
            while (true)
            {
                if (people > 0)
                {
                    courses += 1;
                    people -= elevatorCapacity;
                }
                else
                {
                    Console.WriteLine(courses);
                    break;
                }
            }
        }
    }
}
