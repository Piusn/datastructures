namespace DataStructures.CommonLibrary.Graph
{
    public class Edge
    {
        public Vertex Left { get; set; }
        public Vertex Right { get; set; }
        public int Weight { get; set; }
        public Edge(Vertex left, Vertex right)
        {
            this.Left = left;
            this.Right = right;
        }

        public Edge(Vertex left, Vertex right, int weight) : this(left, right)
        {
            this.Weight = weight;
        }
    }
}
