using System;
using System.Collections.Generic;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person(data[0], data[1], int.Parse(data[2]),decimal.Parse(data[3]));
                people.Add(person);
            }
            var percentage = decimal.Parse(Console.ReadLine());
            people.ForEach(p => p.IncreaseSalary(percentage));
            people.ForEach(p => Console.WriteLine(p));
        }
    }
}
