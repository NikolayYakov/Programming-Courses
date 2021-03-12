using System;

namespace Telephony
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] urls = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            ISmartphone smartPhone = new Smartphone();
            IStationary stationary = new Stationary();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i].Length == 10)
                {
                    smartPhone.Call(numbers[i]);
                }
                else
                {
                    stationary.Call(numbers[i]);
                }
            }
            for (int i = 0; i < urls.Length; i++)
            {
                smartPhone.Brows(urls[i]);
            }
        }
    }
}
