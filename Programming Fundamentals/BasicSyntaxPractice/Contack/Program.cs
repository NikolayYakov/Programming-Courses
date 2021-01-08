using System;

namespace Contack
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string contact = Console.ReadLine();
            Console.WriteLine($"{firstName}{contact}{lastName}");
        }
    }
}
