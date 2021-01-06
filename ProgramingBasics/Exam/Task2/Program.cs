using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            int ilindenHealth = int.Parse(Console.ReadLine());
            power *= people;
            int difference = Math.Abs(power - ilindenHealth);
            if (power < ilindenHealth)
            {
                Console.WriteLine($"You are not prepared! You need {difference} more points.");
                

            }
            else
            {
                Console.WriteLine($"Illidan has been slain! You defeated him with {difference} points.");
            }
        }
    }
}
