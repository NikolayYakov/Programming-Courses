using System;

namespace JedaiAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var students = double.Parse(Console.ReadLine());
            var lightsaberPrice = double.Parse(Console.ReadLine());
            var robePrice = double.Parse(Console.ReadLine());
            var beltPrice = double.Parse(Console.ReadLine());
            var moneyNeeded = 0.0;
            var beltsFree = students / 6.0;
            beltsFree = Math.Floor(beltsFree);
            var saberReserve = students * 1.10;
            saberReserve = Math.Ceiling(saberReserve);
            lightsaberPrice *=saberReserve ;
             
            moneyNeeded += lightsaberPrice;
            robePrice *= students;
            moneyNeeded += robePrice;
            students -= beltsFree;
            beltPrice *= students;
            moneyNeeded += beltPrice;
            if (budget >= moneyNeeded)
            {
                Console.WriteLine($"The money is enough - it would cost {moneyNeeded:f2}lv.");
            }
            else
            {
                moneyNeeded -= budget;
                Console.WriteLine($"Ivan Cho will need {moneyNeeded:f2}lv more.");
            }
        }
    }
}
