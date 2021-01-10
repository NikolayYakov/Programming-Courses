using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double result = Calculations(firstNumber, symbol, secondNumber);
            Console.WriteLine(result);
        }
        static double Calculations(double firstNumber,char symbo,double secondNumber)
        {
            double result = 0.0;
            switch (symbo)
            {
                case '+':
                    result = firstNumber + secondNumber;
                    break;
                case '-':
                    result = firstNumber - secondNumber;
                    break;
                case '*':
                    result = firstNumber * secondNumber;
                    break;
                case '/':
                    result = firstNumber / secondNumber;
                    break;
                    
            }
            return result;
        }
    }
}
