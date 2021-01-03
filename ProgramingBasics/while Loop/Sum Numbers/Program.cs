using System;

namespace Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            while (true)
            {
                int secondNumber = int.Parse(Console.ReadLine());
                sum += secondNumber;
                if (sum >= number)
                {
                    Console.WriteLine(sum);
                    break;
                }
            }
        }
    }
}
