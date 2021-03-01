using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();
            for(int i = 0; i < lines; i++)
            {
                string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person(data[0], data[1], int.Parse(data[2]));
                people.Add(person);
            }
            people = people.OrderBy(p => p.FirstName)
                           .ThenBy(p => p.Age)
                           .ToList();
            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}
