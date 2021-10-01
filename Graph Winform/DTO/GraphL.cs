using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms.VisualStyles;

namespace Graph_Winform.DTO
{
    public class GraphL : Graph
    {
        public GraphL() : base()
        {

        }

        public static implicit operator GraphM(GraphL graph)
        {
            GraphM newGraph = new GraphM();
            newGraph.Directed = graph.Directed;

            foreach (var vertex in graph.Vertices)
            {
                newGraph.AddVertex(vertex.Label);
            }

            foreach (var vertex in graph.Vertices)
            {
                Edge edge = vertex.Edges;
                while (edge != null)
                {
                    newGraph.AddEdge(vertex.Label, edge.End, edge.Weight);
                    edge = edge.Next;
                }
            }

            return newGraph;
        }

        public override int this[string start, string end]
        {
            get
            {
                Edge edge = GetEdge(start, end);
                return edge is null ? 0 : edge.Weight;
            }

            set
            {
                int index = FindIndexVertex(start);
                if (Vertices[index].Edges is null)
                {
                    Vertices[index].Edges = new Edge(end, value);
                    return;
                }
                else if (Vertices[index].Edges.End == end)
                {
                    if (value == 0)
                    {
                        Vertices[index].Edges = Vertices[index].Edges.Next;
                    }
                    else
                    {
                        Vertices[index].Edges.Weight = value;
                    }
                    return;
                }

                Edge edge = Vertices[index].Edges;
                AssignEdge(edge, end, value);
            }
        }

        private Edge GetEdge(string start, string end)
        {
            int index = FindIndexVertex(start);
            Edge edge = Vertices[index].Edges;
            while (edge != null)
            {
                if (edge.End == end)
                {
                    break;
                }
                edge = edge.Next;
            }
            return edge;
        }

        private void AssignEdge(Edge edge, string end, int weight)
        {
            Edge prevEdge = edge;
            while (edge.Next != null)
            {
                edge = edge.Next;
                if (edge.End == end)
                {
                    if (weight == 0)
                    {
                        prevEdge.Next = edge.Next;
                    }
                    else
                    {
                        edge.Weight = weight;
                    }
                    return;
                }

                prevEdge = edge;
            }

            if (weight != 0)
            {
                prevEdge.Next = new Edge(end, weight);
            }
        }

        protected override void WriteFile(StreamWriter writer)
        {
            base.WriteFile(writer);

            foreach (var vertex in Vertices)
            {
                Edge edge = vertex.Edges;
                while (edge != null)
                {
                    string[] items =
                    {
                        vertex.Label,
                        edge.End,
                        edge.Weight.ToString()
                    };
                    writer.WriteLine(string.Join("\t", items));

                    edge = edge.Next;
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("V = " + NumVertices + ", E = " + NumEdges);
            sb.AppendLine("Directed: " + Directed);

            foreach (var vertex in Vertices)
            {
                sb.Append(vertex);
                Edge edge = vertex.Edges;
                while (edge != null)
                {
                    sb.AppendFormat(" -> {0} : {1}", edge.End, edge.Weight);
                    edge = edge.Next;
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }

        public override List<Edge> GetEdges()
        {
            List<Edge> edges = new List<Edge>();
            foreach (var vertex in Vertices)
            {
                string start = vertex.Label;
                Edge edge = vertex.Edges;
                while (edge != null)
                {
                    edges.Add(new Edge()
                    {
                        Start = start,
                        End = edge.End,
                        Weight = edge.Weight
                    });
                    edge = edge.Next;
                }
            }
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
            int count = 1;

            int index = FindIndexVertex(start);
            Vertex vertex = Vertices[index];
            vertex.IsVisited = true;

            sb.AppendLine(vertex.Label);
            vertex.Text = count.ToString();

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
                    ++count;
                    vertex.Text = count.ToString();

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

            sb.AppendLine(vertex.Label);
            //vertex.Text = count.ToString();

            queue.Enqueue(vertex);
            while (queue.Count != 0)
            {
                index = FindFirstAdjacentVertex(vertex.Label);
                if (index == -1)
                {
                    queue.Dequeue();
                    if (queue.Count != 0)
                    {
                        vertex = queue.Peek();
                    }
                }
                else
                {
                    Vertices[index].IsVisited = true;
                    queue.Enqueue(Vertices[index]);

                    sb.AppendLine(Vertices[index].Label);
                    //++count;
                    //Vertices[index].Text = count.ToString();
                }
            }
            ResetFlags();

            return sb.ToString();
        }

        public override int Prim()
        {
            throw new System.NotImplementedException();
        }

        public override int Kruskal()
        {
            throw new System.NotImplementedException();
        }
    }
}
