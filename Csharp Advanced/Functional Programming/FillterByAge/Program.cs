using System;

namespace FillterByAge
{
    public class People
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            People[] person = new People[count];
            for(int i = 0; i < count; i++)
            {
                string[] data = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string name = data[0];
                int age = int.Parse(data[1]);
                person[i] = new People();
                person[i].Name = name;
                person[i].Age = age;
            }
            string filter = Console.ReadLine();
            int fillterAge = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();
            Func<People, bool> condition = GetAgeCondition(filter, fillterAge);
            Func<People, string> formater = Formater(format);
            PrintPeople(person, condition,formater);


        }
        static Func<People,string> Formater(string format)
        {
            switch (format)
            {
                case "name":return p => $"{p.Name}";
                case "age": return p => $"{p.Age}";
                case "name age": return p => $"{p.Name} - {p.Age}";
                default: return null;
             }
        }
        static Func<People,bool> GetAgeCondition(string filter,int fillterAge)
        {
            switch (filter)
            {
                case "younger": return p => p.Age < fillterAge;
                case "older": return p => p.Age >= fillterAge;
                default: return null;
            }
        }
        static void PrintPeople(People[] people,Func<People,bool> condition,Func<People,string> format)
        {
            foreach (var person in people )
            {
                if (condition(person))
                {
                    Console.WriteLine(format(person));
                }
            }
        }
    }
}
