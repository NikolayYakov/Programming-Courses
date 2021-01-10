using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string function = Console.ReadLine();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            MatematicFunction(function, firstNumber, secondNumber);
        }
        static void MatematicFunction(string function, int firstNumber, int secondNumber)
        {
            int result = 0;
            switch (function)
            {
                case "add":
                    result = firstNumber + secondNumber;
                    break;
                case "multiply":
                    result = firstNumber * secondNumber;
                    break;
                case "subtract":
                    result = firstNumber - secondNumber;
                    break;
                case "divide":
                    result = firstNumber / secondNumber;
                    break;
               
            }
            Console.WriteLine(result);
        }
    }
}
