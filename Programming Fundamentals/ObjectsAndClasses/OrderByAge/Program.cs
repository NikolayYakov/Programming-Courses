using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string[] info = Console.ReadLine()
                                   .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            while (info[0] != "End")
            {
                string firstName = info[0];
                string id = info[1];
                int age = int.Parse(info[2]);
                Person person = new Person(firstName, id, age);
                people.Add(person);
                info = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            List<Person> fillter = people.OrderBy(p => p.Age).ToList();

            foreach  (Person p in fillter)
            {
                Console.WriteLine($"{p.FirstName} with ID: {p.ID} is {p.Age} years old.");
            }
        }
    }
    class Person
    {
        public Person(string firstName,string id,int age)
        {
            FirstName = firstName;
            ID = id;
            Age = age;
        }
        public string FirstName { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }


    }
}
