using System;

namespace Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split();
            string name = firstLine[0] + " " + firstLine[1];
            string adress = firstLine[2];
            TuplaClasscs<string, string> first = new TuplaClasscs<string, string>(name, adress);
            Console.WriteLine(first);
            string[] secondLine = Console.ReadLine().Split();
            string nameDrink = secondLine[0];
            int bears = int.Parse(secondLine[1]);
            TuplaClasscs<string, int> second = new TuplaClasscs<string, int>(nameDrink, bears);
            Console.WriteLine(second);
            string[] thirdLine = Console.ReadLine().Split();
            int number = int.Parse(thirdLine[0]);
            double doubleNumber = double.Parse(thirdLine[1]);
            TuplaClasscs<int, double> third = new TuplaClasscs<int, double>(number, doubleNumber);
            Console.WriteLine(third);
             

        }
    }
}
