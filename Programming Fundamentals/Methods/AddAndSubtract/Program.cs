using System;

namespace AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int result = Add(firstNumber, secondNumber);
            int finalScore = Subtract(result, thirdNumber);
            Console.WriteLine(finalScore);
        }
        static int Add(int firstNumber,int secondNumber)
        {
            return firstNumber + secondNumber;
        }
        static int Subtract(int added, int thirdNumber)
        {
            return added - thirdNumber;
        }
    }
}
