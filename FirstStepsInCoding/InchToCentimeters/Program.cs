using System;

namespace InchToCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double Inch = double.Parse(Console.ReadLine());
            double Centimeters = Inch * 2.54;
            Console.WriteLine(Centimeters);
        }
    }
}
