using System;

namespace RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            var lostGames = int.Parse(Console.ReadLine());
            var headsetPrice = double.Parse(Console.ReadLine());
            var mousePrice = double.Parse(Console.ReadLine());
            var keyboardPrice = double.Parse(Console.ReadLine());
            var displayPrice = double.Parse(Console.ReadLine());
            var rageExpenses = 0.0;
            var counter = 0;
            for(int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    rageExpenses += headsetPrice;

                }
                if (i % 3 == 0)
                {
                    rageExpenses += mousePrice;
                }
                if (i % 3 == 0 && i % 2 == 0)
                {
                    rageExpenses += keyboardPrice;
                    counter++;
                }
                if (counter == 2)
                {
                    rageExpenses += displayPrice;
                    counter = 0;
                }
            }
            Console.WriteLine($"Rage expenses: {rageExpenses:f2} lv.");
        }
    }
}
