using System;

namespace Threeuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split();
            string name = firstLine[0] + " " + firstLine[1];
            string adress = firstLine[2];
            string town = firstLine[3];
            Treeple<string, string, string> first = new Treeple<string, string, string>(name, adress, town);
            Console.WriteLine(first);
            string[] secondLine = Console.ReadLine().Split();
            string nameDrink = secondLine[0];
            int bears = int.Parse(secondLine[1]);
            bool isDrunk = false;
            if (secondLine[2] == "drunk")
            {
                isDrunk = true;
            }
            Treeple<string, int, bool> second = new Treeple<string, int, bool>(nameDrink,bears,isDrunk);
            Console.WriteLine(second);
            string[] thirdLine = Console.ReadLine().Split();
            string moneyName = thirdLine[0];
            double money = double.Parse(thirdLine[1]);
            string backName = thirdLine[2];
            Treeple<string, double, string> third = new Treeple<string, double, string>(moneyName, money, backName);
            Console.WriteLine(third);
        }
    }
}
