using System;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var number = input;
            var currentNumber = 0;
            var factorialSum = 0;
            var factorial = 1;
            while (number != 0)
            {
                currentNumber = number % 10;
                number /= 10;
                for(int i = 1; i <=currentNumber; i++)
                {
                   
                    factorial *= i;
                    
                }
                factorialSum += factorial;
                factorial = 1;
            }
           
            
            if (input == factorialSum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
