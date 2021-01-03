using System;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int maxValue = int.MinValue;
            while (number != "Stop")
            {
                int realNumber = int.Parse(number);
                if (maxValue < realNumber)
                {
                    maxValue = realNumber;
                }
                number = Console.ReadLine();
                 
            }
            Console.WriteLine(maxValue);
        }
    }
}
