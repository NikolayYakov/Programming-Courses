using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();
            family.People = new List<Person>();
            for(int i = 0; i < n; i++)
            {
                string[] date = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person(date[0],int.Parse(date[1]));
                family.AddMember(person);
                
            }
            Person oldest = family.GetOldestMember();
            Console.WriteLine($"{oldest.Name} {oldest.Age}");

        }
    }
}
