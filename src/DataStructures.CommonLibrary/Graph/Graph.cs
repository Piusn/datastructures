using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.CommonLibrary.Graph
{
    public class Graph
    {
        public Dictionary<int, Vertex> Vertexes { get; set; }
        public List<Edge> Edges { get; set; }
        public bool IsWeighted { get; set; }
        public Graph(bool isWeighted)
        {
            Vertexes = new Dictionary<int, Vertex>();
            Edges = new List<Edge>();
            this.IsWeighted = isWeighted;
        }

        public void AddVertex(int id)
        {
            if (!Vertexes.ContainsKey(id))
            {
                Vertexes[id] = new Vertex(id);
            }
        }

        public void AddEdge(int id1, int id2, int weight)
        {
            Vertex left = null;

            if (!this.Vertexes.ContainsKey(id1))
            {
                left = Vertexes[id1] = new Vertex(id1);
            }
            else
            {
                left = Vertexes[id1];
            }

            Vertex right = default(Vertex);

            if (!this.Vertexes.ContainsKey(id2))
            {
                right = Vertexes[id2] = new Vertex(id2);
            }
            else
            {
                right = Vertexes[id2];
            }

            Edge edge = new Edge(left, right, weight);
            left.AddEdge(edge, right);

            this.Edges.Add(edge);

        }

        public void AddEdge(int id1, int id2)
        {
            Vertex left = null;

            if (!this.Vertexes.ContainsKey(id1))
            {
                left = Vertexes[id1] = new Vertex(id1);
            }
            else
            {
                left = Vertexes[id1];
            }

            Vertex right = default(Vertex);

            if (!this.Vertexes.ContainsKey(id2))
            {
                right = Vertexes[id2] = new Vertex(id2);
            }
            else
            {
                right = Vertexes[id2];
            }

            Edge edge = new Edge(left, right);
            left.AddEdge(edge, right);

            this.Edges.Add(edge);
        }


    }
}
