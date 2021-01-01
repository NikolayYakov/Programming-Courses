using System;
using System.Runtime.CompilerServices;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine();
            double p = int.Parse(Console.ReadLine());
            double h = int.Parse(Console.ReadLine());
            double weekends = 48;
            double weekendsInSofia = weekends - h;
            double weekendsForVolleyball = weekendsInSofia * 3 / 4;
            double weekendsInHomeTown = h;
            double holidaysGamesInSofia = p * 2 / 3;
            double allGames = weekendsForVolleyball + weekendsInHomeTown + holidaysGamesInSofia;
            if (yearType == "leap")
            {
                double bonusGames = allGames * 0.15;
                allGames += bonusGames;
            }
            Console.WriteLine(Math.Floor(allGames));
        }
    }
}
