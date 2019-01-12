using System.Collections.Generic;
using System.Linq;

namespace DataStructures.CommonLibrary.Graph
{
    public class Vertex
    {
        public int Id { get; set; }
        public List<Edge> Edges { get; set; }
        public List<Vertex> AdjacentVertices { get; set; }

        public Vertex(int id)
        {
            Edges = new List<Edge>();
            this.AdjacentVertices = new List<Vertex>();
            this.Id = id;
        }

        public void AddEdge(Edge edge, Vertex vertex)
        {
            this.AdjacentVertices.Add(vertex);
            this.Edges.Add(edge);
        }

     
        public bool HasEdges {
            get {
                return this.Edges.Any();
            }
        }
    }
}
