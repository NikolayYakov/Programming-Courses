using System;

namespace graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int counter = 0;
            int yearcounter = 0;
            double averageGrade = 0.0;
            
            
            while (counter<2)
            {
                double yearGrade = double.Parse(Console.ReadLine());
                yearcounter += 1;
                averageGrade += yearGrade;
                if (yearGrade < 4)
                {
                    counter += 1;
                }
                if (yearcounter >= 12) 
                {
                    averageGrade /= 12.0;
                    Console.WriteLine($"{studentName} graduated. Average grade: {averageGrade:f2}");
                    break;
                }

            }
            if (counter == 2)
            {
                yearcounter -= 1;
                Console.WriteLine($"{studentName} has been excluded at {yearcounter} grade");
            }
           
        }
    }
}
