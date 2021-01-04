using System;

namespace building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floars = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());
            for(int f = floars; f != 0; f--)
            {
                for(int r=0; r<rooms;r++) 
                {
                    if (f == floars)
                    {
                        Console.Write($"L{f}{r} ");
                         
                    }
                    
                    else if (f % 2 == 0)
                    {
                        Console.Write($"O{f}{r} ");
                    }
                    else
                    {
                        Console.Write($"A{f}{r} ");
                    }
                    if (r == rooms - 1)
                    {
                        Console.WriteLine("");
                    }
                }
            }
 
        }
    }
}
