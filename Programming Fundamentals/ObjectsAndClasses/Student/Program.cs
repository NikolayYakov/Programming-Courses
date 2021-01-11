using System;
using System.Collections.Generic;
using System.Linq;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] tockens = command.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string firstNmae = tockens[0];
                string lastNmae = tockens[1];
                int age = int.Parse(tockens[2]);
                string city = tockens[3];
                Student student = new Student()
                {
                    FirstName = firstNmae,
                    LastName = lastNmae,
                    Age = age,
                    City = city


                };
                students.Add(student);
                command = Console.ReadLine();

            }
            string fillterCity = Console.ReadLine();
            
            foreach (Student student in students)
            {
                if (student.City == fillterCity)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");

                }
                 
            }
        }
    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }


    }
}
