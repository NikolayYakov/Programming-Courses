using System;
using System.Collections.Generic;

namespace Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kids = Console.ReadLine().Split();
            Queue<string> hotPatato = new Queue<string>(kids);
            int throws = int.Parse(Console.ReadLine());
            int count = 1;
            while (hotPatato.Count > 1)
            {

                if (count == throws)
                {
                    Console.WriteLine($"Removed {hotPatato.Dequeue()}");
                    count = 1;
 
                }
                else
                {
                    count++;
                    string kid = hotPatato.Dequeue();
                    hotPatato.Enqueue(kid);
                }
            }
            Console.WriteLine($"Last is {hotPatato.Dequeue()}");
        }
    }
}
