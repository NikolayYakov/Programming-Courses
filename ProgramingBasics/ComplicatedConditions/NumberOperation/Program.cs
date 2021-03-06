﻿using System;

namespace OperationsBetweenNumbers2
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = int.Parse(Console.ReadLine());
            double number2 = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double result = 0.0;
            switch (operation)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    result = number1 / number2;
                    break;
                case "%":
                    result = number1 % number2;
                    break;

            }
            switch (operation)
            {
                case "+":
                

                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{number1} + {number2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{number1} + {number2} = {result} - odd");
                    }
                    break;
                case "-":
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{number1} - {number2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{number1} - {number2} = {result} - odd");
                    }
                    break;
                case "*":
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{number1} * {number2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{number1} * {number2} = {result} - odd");
                    }
                    break;
                case "/":
                    if (number2 != 0)
                    {
                        Console.WriteLine($"{number1} / {number2} = {result:f2}");
                    }
                    else
                    {
                        Console.WriteLine($"Cannot divide {number1} by zero");
                    }
                    break;
                case "%":
                    if (number2 != 0)
                    {
                        Console.WriteLine($"{number1} % {number2} = {result}");
                    }
                    else
                    {
                        Console.WriteLine($"Cannot divide {number1} by zero");
                    }
                    break;
            }
        }
    }
}
