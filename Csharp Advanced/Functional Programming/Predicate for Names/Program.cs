using System;

namespace Predicate_for_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Predicate<string> checkLenght = n => n.Length <= lenght;
            PrintName(names, checkLenght);
        }
        static void PrintName(string[] names,Predicate<string> checkLenght)
        {
            foreach (var name in names)
            {
                if (checkLenght(name))
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
