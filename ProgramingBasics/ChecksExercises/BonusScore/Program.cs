using System;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            double score = double.Parse(Console.ReadLine());
             double bonusPoints = 0.0;
            double firstScore = score - bonusPoints;
            if (score <= 100)
            {
                bonusPoints += 5;
                score += bonusPoints;
            }
            else if (score > 1000)
            {
                bonusPoints = score * 10 / 100;
                score += bonusPoints;
            }
            else
            {
                bonusPoints = score * 20 / 100;
                score += bonusPoints;
            }

            if (firstScore % 2 == 0)
            {
                bonusPoints= bonusPoints+1;
                score +=1;
            }
            else if (firstScore % 5 == 0)
            {
                bonusPoints=bonusPoints+2;
                score += 2;
            }
            Console.WriteLine(bonusPoints);
            Console.WriteLine(score);
        }
    }
}
