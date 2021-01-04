using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int judge = int.Parse(Console.ReadLine());
            double averageScore = 0.0;
            double assignmentScore = 0.0;
            double grades = 0;
            while (true)
            {
                string presentation = Console.ReadLine();
                if (presentation == "Finish")
                {
                    break;
                }
                for(double grade = 1.0; grade <= judge; grade++)
                {
                    double score = double.Parse(Console.ReadLine());
                    assignmentScore += score;
                    averageScore += score;
                    
                    grades += 1.0;
                }
                assignmentScore /= judge;
                Console.WriteLine($"{presentation} - {assignmentScore:f2}.");
                assignmentScore = 0.0;
            }
            averageScore /= grades;
            Console.WriteLine($"Student's final assessment is {averageScore:f2}.");
        }
    }
}
