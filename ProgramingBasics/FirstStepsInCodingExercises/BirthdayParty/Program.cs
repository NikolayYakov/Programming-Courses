using System;

namespace BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double hallRent = double.Parse(Console.ReadLine());
            double cake = hallRent * 20 / 100;
            double drinks = cake * 55 / 100;
            double animator = hallRent * 1 / 3;
            double fullPrice = hallRent + cake + drinks + animator;
            Console.WriteLine(fullPrice);
        }
    }
}
