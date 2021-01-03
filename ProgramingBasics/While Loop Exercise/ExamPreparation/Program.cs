using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());
            int counter = 0;
            double averageGrade = 0.0;
            double projectCounter = 0.0;
            string lastProject = "";
            while (true)
            {
                string project = Console.ReadLine();
                if(project== "Enough")
                {
                    averageGrade = averageGrade / projectCounter;
                    Console.WriteLine($"Average score: {averageGrade:f2}");
                    Console.WriteLine($"Number of problems: {projectCounter:f0}");
                    Console.WriteLine($"Last problem: {lastProject}");
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                projectCounter += 1;
                averageGrade += grade;
                if (grade <= 4)
                {
                    counter += 1;
                }
                if (counter == badGrades)
                {
                    Console.WriteLine($"You need a break, {counter} poor grades.");
                    break;
                }
                lastProject = project;
            }
        }
    }
}
