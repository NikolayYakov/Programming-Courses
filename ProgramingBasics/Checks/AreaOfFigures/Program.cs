using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                double squareArea = side * side;
                Console.WriteLine(Math.Round(squareArea,3));
            }
            else if (figure == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                double rectangleArea = sideA * sideB;
                Console.WriteLine(Math.Round(rectangleArea,3));

            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double circleArea = radius * radius * Math.PI;
                Console.WriteLine(Math.Round(circleArea,3));
            }
            else if (figure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double triangleArea = side * height / 2;
                Console.WriteLine(Math.Round(triangleArea, 2));
            }
        }
    }
}
