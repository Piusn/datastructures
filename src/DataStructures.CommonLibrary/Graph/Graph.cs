using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.CommonLibrary.Graph
{
    public class Graph
    {
        public List<Vertex> Vertexes { get; set; }
        public List<Edge> Edges { get; set; }

        public Graph()
        {
            Vertexes = new List<Vertex>();
        }

        public void AddVertex(Vertex vertex)
        {
            Vertexes.Add(vertex);
        }
    }
}
