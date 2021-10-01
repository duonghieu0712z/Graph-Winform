using Graph_Winform.Components;
using System.Drawing;
using System.Windows.Forms;

namespace Graph_Winform.DTO
{
    public class Vertex : CircleButton
    {
        private bool isVisited;

        public string Label
        {
            get => text.Text;
            set => text.Text = value;
        }

        public bool IsVisited
        {
            get => isVisited;
            set
            {
                isVisited = value;
                if (isVisited)
                {
                    BackColor = Color.Red;
                }
                else
                {
                    BackColor = Color.LightBlue;
                }
            }
        }

        public Edge Edges { get; set; }

        public Vertex()
        {
            IsVisited = false;
        }

        public Vertex(string label)
        {
            Label = label;
            IsVisited = false;
        }

        public override string ToString()
        {
            return Label;
        }
    }
}
