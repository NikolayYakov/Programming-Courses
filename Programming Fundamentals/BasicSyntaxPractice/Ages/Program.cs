﻿using System;

namespace Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            if (age <= 2)
            {
                Console.WriteLine("baby");
            }
            else if (age <= 13)
            {
                Console.WriteLine("child");
            }
            else if (age <= 19)
            {
                Console.WriteLine("teenager");
            }
            else if (age <= 65)
            {
                Console.WriteLine("adult");
            }
            else if (age >= 66)
            {
                Console.WriteLine("elder");
            }
        }
    }
}