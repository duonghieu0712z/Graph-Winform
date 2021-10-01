using System.Windows.Forms;

namespace Graph_Winform.Components
{
    public partial class GraphControl : UserControl
    {
        public GraphControl()
        {
            InitializeComponent();
        }

        public void SetDataGraph(int numVertices, int numEdges, bool directed)
        {
            txtNumOfVertices.Text = numVertices.ToString();
            txtNumOfEdges.Text = numEdges.ToString();
            chkDirected.Checked = directed;
        }
    }
}
