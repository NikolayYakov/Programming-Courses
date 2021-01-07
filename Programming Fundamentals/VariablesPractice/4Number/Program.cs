using System;

namespace _4Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int lastNumber = int.Parse(Console.ReadLine());
            int sum = 0;
            sum += firstNumber;
            sum += secondNumber;
            sum /= thirdNumber;
            sum *= lastNumber;
            Console.WriteLine(sum);
        }
    }
}
