using System;
using System.Runtime.ConstrainedExecution;

namespace Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int nonPrimeNumber = 0;
            int primeNumbers = 0;
            
            while (number != "stop")
            {
                int realNumber = int.Parse(number);
                int counter = 0;
                if (realNumber < 0)
                {
                    Console.WriteLine("Number is negative.");
                    number = Console.ReadLine();
                    continue;
                }
                for(int i = 2; i < realNumber; i++)
                {
                    if (realNumber % i == 0)
                    {
                        counter++;
                    }
                   
                }
                if (realNumber != 1 && counter == 0)
                {
                    primeNumbers += realNumber;
                }
                else
                {
                    nonPrimeNumber += realNumber;
                }
                number = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeNumbers}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeNumber}");
        }
    }
}
