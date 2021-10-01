using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Graph_Winform.DTO
{
    public class GraphM : Graph
    {
        private Matrix<int> weights = new Matrix<int>();

        private List<Edge> edges;

        public GraphM() : base()
        {

        }

        public static implicit operator GraphL(GraphM graph)
        {
            GraphL newGraph = new GraphL();
            newGraph.Directed = graph.Directed;

            foreach (var vertex in graph.Vertices)
            {
                newGraph.AddVertex(vertex.Label);
            }

            foreach (var vertex1 in graph.Vertices)
            {
                foreach (var vertex2 in graph.Vertices)
                {
                    if (graph.IsConnected(vertex1.Label, vertex2.Label))
                    {
                        newGraph.AddEdge(vertex1.Label, vertex2.Label, graph[vertex1.Label, vertex2.Label]);
                    }
                }
            }

            return newGraph;
        }

        public override int this[string start, string end]
        {
            get
            {
                int row = FindIndexVertex(start);
                int column = FindIndexVertex(end);
                return weights[row, column];
            }

            set
            {
                int row = FindIndexVertex(start);
                int column = FindIndexVertex(end);
                weights[row, column] = value;
            }
        }

        public override void AddVertex(string label)
        {
            base.AddVertex(label);
            weights.AddRow();
            weights.AddColumn();
        }

        public override void RemoveVertex(string label)
        {
            RemoveAllEdgeOfVertex(label);

            int index = FindIndexVertex(label);
            weights.RemoveRow(index);
            weights.RemoveColumn(index);

            Vertices.RemoveAll(v => v.Label == label);

        }

        protected override void WriteFile(StreamWriter writer)
        {
            base.WriteFile(writer);

            for (int i = 0; i < NumVertices; i++)
            {
                string start = Vertices[i].Label;
                for (int j = 0; j < NumVertices; j++)
                {
                    string end = Vertices[j].Label;
                    if (IsConnected(start, end))
                    {
                        string[] items =
                        {
                            start,
                            end,
                            weights[i, j].ToString()
                        };
                        writer.WriteLine(string.Join("\t", items));
                    }
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("V = " + NumVertices + ", E = " + NumEdges);
            sb.AppendLine("Directed: " + Directed);
            sb.AppendLine(string.Join<Vertex>("\t", Vertices));

            for (int i = 0; i < NumVertices; i++)
            {
                for (int j = 0; j < NumVertices; j++)
                {
                    sb.Append(weights[i, j] + "\t");
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }

        private List<Edge> _GetEdges()
        {
            List<Edge> edges = new List<Edge>();
            for (int i = 0; i < NumVertices; i++)
            {
                for (int j = 0; j < NumVertices; j++)
                {
                    if (!Directed && i > j)
                    {
                        continue;
                    }

                    if (weights[i, j] != 0)
                    {
                        edges.Add(new Edge()
                        {
                            Start = Vertices[i].Label,
                            End = Vertices[j].Label,
                            Weight = weights[i, j]
                        });
                    }
                }
            }
            return edges;
        }

        public override void ResetEdges()
        {
            foreach (var edge in edges)
            {
                edge.IsMarked = false;
            }
        }

        public override List<Edge> GetEdges()
        {
            edges = edges ?? _GetEdges();
            return edges;
        }

        public override string DFS(string start)
        {
            if (NumVertices == 0)
            {
                return null;
            }

            Stack<Vertex> stack = new Stack<Vertex>();
            StringBuilder sb = new StringBuilder();
            //int count = 1;

            int index = FindIndexVertex(start);
            Vertex vertex = Vertices[index];
            vertex.IsVisited = true;

            sb.AppendLine(vertex.Label);
            //vertex.Text = count.ToString();

            stack.Push(vertex);
            while (stack.Count != 0)
            {
                vertex = stack.Peek();

                index = FindFirstAdjacentVertex(vertex.Label);
                if (index == -1)
                {
                    stack.Pop();
                }
                else
                {
                    vertex = Vertices[index];
                    vertex.IsVisited = true;

                    sb.AppendLine(vertex.Label);
                    //++count;
                    //vertex.Text = count.ToString();

                    stack.Push(vertex);
                }
            }
            ResetFlags();

            return sb.ToString();
        }

        public override string BFS(string start)
        {
            if (NumVertices == 0)
            {
                return null;
            }

            Queue<Vertex> queue = new Queue<Vertex>();
            StringBuilder sb = new StringBuilder();
            //int count = 1;

            int index = FindIndexVertex(start);
            Vertex vertex = Vertices[index];
            vertex.IsVisited = true;

            queue.Enqueue(vertex);
            while (queue.Count != 0)
            {
                vertex = queue.Dequeue();

                sb.AppendLine(vertex.Label);
                //vertex.Text = count.ToString();
                //++count;

                index = FindFirstAdjacentVertex(vertex.Label);
                while (index != -1)
                {
                    Vertices[index].IsVisited = true;
                    queue.Enqueue(Vertices[index]);

                    index = FindFirstAdjacentVertex(vertex.Label);
                }
            }
            ResetFlags();

            return sb.ToString();
        }

        public override int Prim()
        {
            ResetFlags();
            ResetEdges();

            Path[] tree = new Path[NumVertices];
            for (int i = 0; i < NumVertices; i++)
            {
                tree[i] = new Path()
                {
                    Length = weights[0, i],// == 0 ? int.MaxValue : weights[0, i],
                    Parent = 0
                };
            }

            int min;
            int minVertex;

            for (int i = 1; i < NumVertices; i++)
            {
                min = int.MaxValue;
                minVertex = 1;
                for (int j = 1; j < NumVertices; j++)
                {
                    if (tree[j].Length != 0)
                    {
                        if (!Vertices[j].IsVisited && tree[j].Length < min)
                        {
                            min = tree[j].Length;
                            minVertex = j;
                        }
                    }
                }

                Vertices[minVertex].IsVisited = true;

                for (int j = 1; j < NumVertices; j++)
                {
                    if (tree[j].Length == 0)
                    {
                        tree[j].Length = weights[minVertex, j];
                        tree[j].Parent = minVertex;
                        continue;
                    }

                    if (weights[minVertex, j] != 0)
                    {
                        if (!Vertices[j].IsVisited && weights[minVertex, j] < tree[j].Length)
                        {
                            tree[j].Length = weights[minVertex, j];
                            tree[j].Parent = minVertex;
                        }
                    }
                }
            }

            ResetFlags();
            int sum = 0;
            for (int i = 1; i < NumVertices; i++)
            {
                int j = tree[i].Parent;
                sum += tree[i].Length;
                if (Directed)
                {
                    if (IsConnected(Vertices[j].Label, Vertices[i].Label))
                    {
                        Edge edge = edges.Find(e => e.Start == Vertices[j].Label && e.End == Vertices[i].Label);
                        edge.IsMarked = true;
                    }
                    continue;
                }

                if (i < j)
                {
                    Edge edge = edges.Find(e => e.Start == Vertices[i].Label && e.End == Vertices[j].Label);
                    edge.IsMarked = true;
                }
                else
                {
                    Edge edge = edges.Find(e => e.Start == Vertices[j].Label && e.End == Vertices[i].Label);
                    edge.IsMarked = true;
                }
            }
            return sum;
        }

        int Find(int[] leader, int x)
        {
            while (x != leader[x])
            {
                x = leader[x];
            }
            return x;
        }

        bool Union(int[] leader, Edge e)
        {
            int x = Find(leader, FindIndexVertex(e.Start));
            int y = Find(leader, FindIndexVertex(e.End));

            if (x == y)
            {
                return false;
            }

            if (x < y)
            {
                leader[y] = x;
            }
            else
            {
                leader[x] = y;
            }
            return true;
        }

        public override int Kruskal()
        {
            ResetFlags();
            ResetEdges();

            edges.Sort((e1, e2) => e1.Weight - e2.Weight);

            int[] leader = new int[NumVertices + 1];
            for (int i = 0; i < NumVertices + 1; i++)
            {
                leader[i] = i;
            }

            int count = 0;
            int sum = 0;
            for (int i = 0; i < NumEdges; i++)
            {
                if (Union(leader, edges[i]))
                {
                    edges[i].IsMarked = true;
                    sum += edges[i].Weight;
                    ++count;

                    if (count == NumVertices - 1)
                    {
                        break;
                    }
                }
            }
            return sum;
        }
    }
}
