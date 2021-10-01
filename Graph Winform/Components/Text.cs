using System.Drawing;
using System.Windows.Forms;

namespace Graph_Winform.Components
{
    public partial class Text : Label
    {
        public Text()
        {
            InitializeComponent();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            //BringToFront();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == MouseButtons.Left)
            {
                Size offset = new Size(Width / 2, Height / 2);
                Location += (Size)e.Location - offset;
            }
        }
    }
}
