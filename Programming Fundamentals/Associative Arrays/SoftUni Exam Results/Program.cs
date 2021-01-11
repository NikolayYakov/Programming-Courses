using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> students = new Dictionary<string, int>();
            Dictionary<string, int> languages = new Dictionary<string, int>();
            string[] command = Console.ReadLine()
                                      .Split("-", StringSplitOptions.RemoveEmptyEntries);
            
            while(command[0]!= "exam finished")
            {
                if (command.Contains("banned")==false)
                {
                    string name = command[0];
                    int points = int.Parse(command[2]);
                    string language = command[1];
                    if (students.ContainsKey(name) == false)
                    {
                        students.Add(name, points);
                    }
                    else
                    {
                        if (students[name] < points)
                        {
                            students[name] = points;
                        }
                    }
                   
                    if (languages.ContainsKey(language))
                    {
                        languages[language]++;
                    }
                    else
                    {
                        languages.Add(language, 1);
                    }
 
                }
                else
                {
                    string name = command[0];
                    if (students.ContainsKey(name))
                    {
                        students.Remove(name);
                    }
                }
                command = Console.ReadLine()
                                  .Split("-", StringSplitOptions.RemoveEmptyEntries);

            }
            Console.WriteLine("Results:");
            foreach (var student in students.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{student.Key} | {student.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var language in languages.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{language.Key} - {language.Value}");
            }
             
        }
    }
}
