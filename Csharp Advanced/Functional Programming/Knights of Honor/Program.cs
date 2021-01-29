using System;

namespace Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Action<string[]> knight = SirTitle;
            knight(names);
        }
        static void SirTitle(string[] names)
        {
            foreach (var name in names)
            {
                Console.WriteLine($"Sir {name}");
            }
        }
    }
}
