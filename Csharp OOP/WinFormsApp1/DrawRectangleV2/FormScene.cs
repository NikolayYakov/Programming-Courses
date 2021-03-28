using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawRectangle
{
    public partial class FormScene : Form
    {
        private List<Rectangle> rectangles = new List<Rectangle>();
        public FormScene()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            foreach (var item in rectangles)
            {
                item.Paint(e.Graphics);
            }
        }

        private void FormScene_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Rectangle rectangle = new Rectangle()
                {
                    Location = e.Location,
                    Width = 100,
                    Height = 200,
                    Color = Color.Blue
                };
                using (var g = CreateGraphics())
                {
                    rectangle.Paint(g);

                }
                rectangles.Add(rectangle);
            }
            else if(e.Button ==MouseButtons.Left)
            {
                foreach (var item in rectangles)
                {
                    if (item.Contains(e.Location) == true)
                    {
                        item.Color = Color.Red;
                    }
                    else
                    {
                        item.Color = Color.Blue;
                    }
                }
            }
            Invalidate();
        }

        private void FormScene_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                int index = 0;
                bool isRed = false;
                foreach (var item in rectangles)
                {

                    if (item.Color == Color.Red)
                    {
                        isRed = true;
                        break;
                    }
                    index++;
                }
                if (isRed == true)
                {
                    rectangles.RemoveAt(index);
                }
                Invalidate();
            }
          
        }
    }
}
