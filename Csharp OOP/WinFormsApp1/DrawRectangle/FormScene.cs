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
            Rectangle rectangle = new Rectangle()
            {
                Location = e.Location,
                Width = 100,
                Height = 200
            };
            using (var g = CreateGraphics())
            {
                rectangle.Paint(g);

            }
            rectangles.Add(rectangle);
            Invalidate();
        }
    }
}
