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
        public Color Color { get; set; }
        public void Paint(Graphics g)
        {
            var color = Color.FromArgb(100, Color);
            using (var brush = new SolidBrush(color))
            {
                g.FillRectangle(brush, Location.X, Location.Y, Width, Height);
            }
            using (var pen = new Pen(Color, 3))
            {
                g.DrawRectangle(pen, Location.X, Location.Y, Width, Height);
            }
           
            
        }
        public bool Contains(Point p)
        {
            return Location.X < p.X && p.X < Location.X + Width&& Location.Y < p.Y && p.Y < Location.Y + Height;


        }
    }
}
