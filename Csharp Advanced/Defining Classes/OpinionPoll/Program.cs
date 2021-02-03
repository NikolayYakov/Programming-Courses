using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> group = new List<Person>();
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string[] date = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person(date[0], int.Parse(date[1]));
                group.Add(person);
            }
            group = group.Where(p => p.Age > 30).OrderBy(p => p.Name).ToList();
            foreach (var person in group)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
