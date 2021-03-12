using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : IDrawable
    {
        private int width;
        private int height;
        public Rectangle(int width,int height)
        {
            Width = width;
            Height = height;
        }
        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }
        public int Height 
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        } 
        public void Draw()
        {
            for (int row = 0; row < Height; row++)
            {
                for (int col = 0; col < Width; col++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
