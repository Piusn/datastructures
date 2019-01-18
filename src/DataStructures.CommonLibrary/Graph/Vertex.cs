using System.Collections.Generic;
using System.Linq;

namespace DataStructures.CommonLibrary.Graph
{
    public class Vertex
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Vertex> ShortestPath { get; set; } = new List<Vertex>();

        public int Distance { get; set; } = int.MaxValue;

        public Dictionary<Vertex, int> AdjacentNodes { get; set; } = new Dictionary<Vertex, int>();

        public Vertex(int id)
        {
            this.Id = id;
        }

        public void AddEdge(Vertex vertex, int distance)
        {
            this.AdjacentNodes.Add(vertex, distance);
        }
    }
}
