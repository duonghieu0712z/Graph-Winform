using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Graph_Winform.Components
{
    public partial class CircleButton : Button
    {
        public Point Position
        {
            get => Location + new Size(Radius, Radius);
            set
            {
                Location = value - new Size(Radius, Radius);
                text.Location = Location + new Size(0, 2 * Radius);
            }
        }

        public int Radius
        {
            get => Width / 2;
            set => Size = new Size(2 * value, 2 * value);
        }

        public CircleButton()
        {
            InitializeComponent();

            Radius = 10;
        }

        protected override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);
            Parent?.Controls.Add(text);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            pevent.Graphics.SmoothingMode = SmoothingMode.HighQuality;

            var path = new GraphicsPath();
            path.AddEllipse(0, 0, Width, Height);
            Region = new Region(path);

            base.OnPaint(pevent);

            using (Pen pen = new Pen(Color.Black))
            {
                pen.Alignment = PenAlignment.Inset;
                pevent.Graphics.DrawEllipse(pen, 0.375f, 0.375f, Width - 1, Height - 1);
            }
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            BringToFront();
        }

        protected override void OnMouseMove(MouseEventArgs mevent)
        {
            base.OnMouseMove(mevent);
            if (mevent.Button == MouseButtons.Left)
            {
                Size offset = (Size)Location - (Size)text.Location;
                Location += (Size)mevent.Location - new Size(Radius, Radius);
                text.Location = Location - offset;
            }
        }
    }
}
