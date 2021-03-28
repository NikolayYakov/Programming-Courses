using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DrawRectangle
{
    public class Rectangle
    {
        public Point Location { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public void Paint(Graphics g)
        {
            var color = Color.Blue;
            using(var pen = new Pen(color, 3))
            {
                g.DrawRectangle(pen, Location.X, Location.Y, Width, Height);
            }
            
        }
    }
}
