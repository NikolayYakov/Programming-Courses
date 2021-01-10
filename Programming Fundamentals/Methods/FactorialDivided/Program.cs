using System;

namespace FactorialDivided
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            double firstFactorial = FirstFactorial(firstNumber);
            double secondFactotial = SecondFactorial(secondNumber);
            double result = firstFactorial / secondFactotial;
            Console.WriteLine($"{result:f2}");
        }
        static double FirstFactorial(int number)
        {
            double factorial = 1.0;
            for(int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
        static double SecondFactorial(int number)
        {
            double factorial = 1.0;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
