namespace Graph_Winform.DTO
{
    public class Edge
    {
        public string Start { get; set; }

        public string End { get; set; }

        public int Weight { get; set; }

        public bool IsMarked { get; set; }

        public Edge Next { get; set; }

        public Edge()
        {

        }

        public Edge(string end, int weight)
        {
            End = end;
            Weight = weight;
        }
    }
}
