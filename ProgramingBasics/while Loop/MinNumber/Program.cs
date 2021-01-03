using System;

namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int minValue = int.MaxValue;
            while (number != "Stop")
            {
                int realNumber = int.Parse(number);
                if (minValue > realNumber)
                {
                    minValue = realNumber;
                }
                number = Console.ReadLine();

            }
            Console.WriteLine(minValue);
        }
    }
}
