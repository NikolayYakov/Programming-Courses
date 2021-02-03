using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();
            DateModifier date = new DateModifier();
           int days =date.Calculator(firstDate, secondDate);
            Console.WriteLine(days);

        }
    }
}
