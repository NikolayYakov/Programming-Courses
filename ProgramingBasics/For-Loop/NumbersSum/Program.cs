using System;

namespace NumbersSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int randomNumbers = int.Parse(Console.ReadLine());
            int result = 0;
            for (int i = 0; i < randomNumbers; i++)
            {
                int number = int.Parse(Console.ReadLine());
                result += number;
            }
            Console.WriteLine(result);
        }
    }
}
