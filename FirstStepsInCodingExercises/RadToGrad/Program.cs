using System;

namespace RadToGrad
{
    class Program
    {
        static void Main(string[] args)
        {
            double rad = double.Parse(Console.ReadLine());
            double grad = rad * 180 / Math.PI;
            Console.WriteLine(Math.Round(grad));
        }
    }
}
