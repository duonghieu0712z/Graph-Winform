using Graph_Winform.DTO;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Graph_Winform
{
    public partial class MainForm : Form
    {
        private const int PADDING = 15;

        private Graph graph;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void AddGraph()
        {
            pnPaint.Controls.Clear();
            pnPaint.Controls.Add(graphControl);
            foreach (var item in graph.Vertices)
            {
                pnPaint.Controls.Add(item);
                item.MouseDown += (s, e) => graphControl.BringToFront();
                item.MouseMove += (s, e) =>
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        pnPaint.Invalidate();
                    }
                };
            }
        }

        private void RandomizePosition()
        {
            if (graph is null)
            {
                return;
            }

            int minWidth = PADDING;
            int maxWidth = pnPaint.Width - graphControl.Width - PADDING;
            int minHeight = graphControl.Height + PADDING;
            int maxHeight = pnPaint.Height - PADDING;

            Random rd = new Random();
            foreach (var item in graph.Vertices)
            {
                int x = rd.Next(minWidth, maxWidth);
                int y = rd.Next(minHeight, maxHeight);
                item.Position = new Point(x, y);
            }
        }

        private void GetDataGraph()
        {
            graphControl.SetDataGraph(graph.NumVertices, graph.NumEdges, graph.Directed);
        }

        #region File menu
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                graph = new GraphM();
                graph.OpenFile(openFileDlg.FileName);

                AddGraph();
                RandomizePosition();

                GetDataGraph();
                LoadComboBox();

                pnPaint.Invalidate();
            }
        }

        private void LoadComboBox()
        {
            if (graph is null)
            {
                return;
            }

            cboStartTraversal.DataSource = graph.Vertices;
            cboStartTraversal.DisplayMember = "Label";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region View menu
        private void adjacentMatrixToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adjacentListToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void pnPaint_Paint(object sender, PaintEventArgs e)
        {
            if (graph is null)
            {
                return;
            }

            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            foreach (var edge in graph.GetEdges())
            {
                DrawEdge(e.Graphics, edge);
            }
        }

        private void DrawEdge(Graphics g, Edge edge)
        {
            int i = graph.FindIndexVertex(edge.Start);
            int j = graph.FindIndexVertex(edge.End);
            Point start = graph.Vertices[i].Position;
            Point end = graph.Vertices[j].Position;

            Pen pen = new Pen(Color.Black, 2);
            if (edge.IsMarked)
            {
                pen.Color = Color.OrangeRed;
            }
            g.DrawLine(pen, start, end);

            Point mid = new Point((start.X + end.X) / 2, (start.Y + end.Y) / 2);
            Font font = new Font(Font, FontStyle.Bold);
            g.DrawString(edge.Weight.ToString(), font, Brushes.Red, mid);

            if (graph.Directed)
            {
                var state = g.Save();
                float angle = (float)(180 / Math.PI * Math.Atan2(end.Y - start.Y, end.X - start.X));
                float arrowSize = 20;

                GraphicsPath path = new GraphicsPath();
                path.AddLines(
                    new PointF[]
                    {
                        new PointF(-arrowSize, -arrowSize/3),
                        new PointF(0, 0),
                        new PointF(-arrowSize, arrowSize/3)
                    }
                );

                g.TranslateTransform(mid.X, mid.Y);
                g.RotateTransform(angle);
                g.DrawPath(pen, path);

                g.Restore(state);
            }
        }

        #region Context menu
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            graph.ResetFlags();
            graph.ResetEdges();
            txtSum.Text = "";
            //RandomizePosition();
            pnPaint.Invalidate();
        }
        #endregion

        private void btnDfs_Click(object sender, EventArgs e)
        {
            if (graph is null)
            {
                return;
            }

            int index = cboStartTraversal.SelectedIndex;
            string start = graph.Vertices[index].Label;
            string message = graph.DFS(start);
            MessageBox.Show(message);
        }

        private void btnBfs_Click(object sender, EventArgs e)
        {
            if (graph is null)
            {
                return;
            }

            int index = cboStartTraversal.SelectedIndex;
            string start = graph.Vertices[index].Label;
            string message = graph.BFS(start);
            MessageBox.Show(message);
        }

        private void btnKruskal_Click(object sender, EventArgs e)
        {
            if (graph is null)
            {
                return;
            }

            int sum = graph.Kruskal();
            txtSum.Text = sum.ToString();
            pnPaint.Invalidate();
        }

        private void btnPrim_Click(object sender, EventArgs e)
        {
            if (graph is null)
            {
                return;
            }

            int sum = graph.Prim();
            txtSum.Text = sum.ToString();
            pnPaint.Invalidate();
        }
    }
}
