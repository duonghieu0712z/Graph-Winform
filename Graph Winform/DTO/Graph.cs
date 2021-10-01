using System.Collections.Generic;
using System.IO;

namespace Graph_Winform.DTO
{
    public abstract class Graph
    {
        public int NumVertices => Vertices.Count;

        public int NumEdges { get; private set; }

        public bool Directed { get; set; }

        public List<Vertex> Vertices { get; private set; }

        public Graph()
        {
            Vertices = new List<Vertex>();
        }

        public abstract int this[string start, string end] { get; set; }

        #region Add vertex and edge
        public virtual void AddVertex(string label)
        {
            Vertices.Add(new Vertex(label));
        }

        public virtual void AddEdge(string start, string end, int weight, bool directed)
        {
            if (!IsConnected(start, end))
            {
                ++NumEdges;
            }

            this[start, end] = weight;
            if (!directed)
            {
                this[end, start] = weight;
            }
        }

        public void AddEdge(string start, string end, int weight)
        {
            AddEdge(start, end, weight, Directed);
        }

        public void AddEdge(string start, string end)
        {
            AddEdge(start, end, 1);
        }
        #endregion

        #region Remove vertex and edge
        public virtual void RemoveVertex(string label)
        {
            RemoveAllEdgeOfVertex(label);
            Vertices.RemoveAll(v => v.Label == label);
        }

        public virtual void RemoveAllEdgeOfVertex(string label)
        {
            foreach (var vertex in Vertices)
            {
                if (IsConnected(vertex.Label, label))
                {
                    RemoveEdge(vertex.Label, label);
                }
            }
        }

        public virtual void RemoveEdge(string start, string end, bool directed)
        {
            if (IsConnected(start, end))
            {
                --NumEdges;
            }

            this[start, end] = 0;
            if (!directed)
            {
                this[end, start] = 0;
            }
        }

        public void RemoveEdge(string start, string end)
        {
            RemoveEdge(start, end, Directed);
        }
        #endregion

        public int FindFirstAdjacentVertex(string label)
        {
            return Vertices.FindIndex(v => !v.IsVisited && IsConnected(label, v.Label));
        }

        public int FindIndexVertex(string label)
        {
            return Vertices.FindIndex(v => v.Label == label);
        }

        public bool IsConnected(string start, string end)
        {
            return this[start, end] != 0;
        }

        public void ResetFlags()
        {
            foreach (var vertex in Vertices)
            {
                vertex.Text = "";
                vertex.IsVisited = false;
            }
        }

        public abstract List<Edge> GetEdges();

        public virtual void ResetEdges()
        {

        }

        #region File
        public void OpenFile(string fileName)
        {
            using (var stream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                using (var reader = new StreamReader(stream))
                {
                    ReadFile(reader);
                }
            }
        }

        protected virtual void ReadFile(StreamReader reader)
        {
            int numVertices = int.Parse(reader.ReadLine());
            int numEdges = int.Parse(reader.ReadLine());
            Directed = reader.ReadLine() == "1";

            string[] labels = reader.ReadLine().Split();
            foreach (var label in labels)
            {
                AddVertex(label);
            }

            while (!reader.EndOfStream)
            {
                string[] items = reader.ReadLine().Split();
                AddEdge(items[0], items[1], int.Parse(items[2]));
            }
        }

        public void SaveFile(string fileName)
        {
            using (var stream = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                using (var writer = new StreamWriter(stream))
                {
                    WriteFile(writer);
                }
            }
        }

        protected virtual void WriteFile(StreamWriter writer)
        {
            writer.WriteLine(NumVertices);
            writer.WriteLine(NumEdges);
            writer.WriteLine(Directed ? 1 : 0);

            writer.WriteLine(string.Join<Vertex>("\t", Vertices));
        }
        #endregion

        #region
        public abstract string DFS(string start);

        public abstract string BFS(string start);

        public abstract int Prim();

        public abstract int Kruskal();
        #endregion
    }
}
