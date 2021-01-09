using System;
using System.Linq;
namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int vagons = int.Parse(Console.ReadLine());
            int[] people = new int[vagons];
            int allPeople = 0;
            for(int i = 0; i < vagons; i++)
            {
                people[i] = int.Parse(Console.ReadLine());
                allPeople += people[i];
            }
            string train = string.Join(' ', people);
            Console.WriteLine(train);
            Console.WriteLine(allPeople);
        }
    }
}
