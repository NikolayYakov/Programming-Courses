using System;
using System.Collections.Generic;

namespace ComparingObjects
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            while (command[0] != "END")
            {
                Person person = new Person(command[0], int.Parse(command[1]), command[2]);
                people.Add(person);
                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            int index = int.Parse(Console.ReadLine());
            Person comper = people[index-1];
            int equal = 0;
            int notEqual = 0;
            foreach (var man in people)
            {
                if (man.CompareTo(comper) == 0)
                {
                    equal++;
                }
                else
                {
                    notEqual++;
                }
            }
            if (equal > 1)
            {
                Console.WriteLine($"{equal} {notEqual} {equal + notEqual}");
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
    }
}
