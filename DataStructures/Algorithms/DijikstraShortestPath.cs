using System;
using System.Collections.Generic;
using System.Text;
using DataStructures.CommonLibrary.Graph;

namespace DataStructures.Exercises
{
    //https://github.com/eugenp/tutorials/tree/master/algorithms-miscellaneous-2
    public class DijikstraShortestPath
    {
        CommonLibrary.Graph.Graph graph = new Graph();

        public DijikstraShortestPath()
        {

        }

        public void Run()
        {
            Vertex v1 = new Vertex(1);
            Vertex v2 = new Vertex(2);
            Vertex v3 = new Vertex(3);
            Vertex v4 = new Vertex(4);
            Vertex v5 = new Vertex(5);

            v1.AddEdge(v2, 2);
            v1.AddEdge(v3, 1);
            v1.AddEdge(v4, 7);

            v2.AddEdge(v5, 15);
            v2.AddEdge(v3, 1);

            v4.AddEdge(v3, 8);
            v3.AddEdge(v5, 222);

            graph.Vertexes = new List<Vertex>()
                             {
                                 v1, v2, v3, v4, v5
                             };


            v1.Distance = 0;

            List<Vertex> processed = new List<Vertex>();
            List<Vertex> unprocessed = new List<Vertex>();

            unprocessed.Add(v1);

            while (unprocessed.Count > 0)
            {
                var currentNode = GetLowestDistanceNode(unprocessed);

                //Remove the current node
                unprocessed.Remove(currentNode);

                foreach (var currentNodeAdjacentNode in currentNode.AdjacentNodes)
                {
                    if (!processed.Contains(currentNodeAdjacentNode.Key))
                    {
                        CalculateDistance(currentNode, currentNodeAdjacentNode.Key, currentNodeAdjacentNode.Value);
                        unprocessed.Add(currentNodeAdjacentNode.Key);
                    }
                }

                processed.Add(currentNode);
            }
        }

        public void CalculateDistance(Vertex sourceVertex, Vertex currentVertex, int distance)
        {
            if (currentVertex.Distance > sourceVertex.Distance + distance)
            {
                currentVertex.Distance = sourceVertex.Distance + distance;
                var shortestPath =new List<Vertex>(); 
                shortestPath.AddRange(sourceVertex.ShortestPath);

                shortestPath.Add(currentVertex);
                currentVertex.ShortestPath = shortestPath;
            }
        }

        private Vertex GetLowestDistanceNode(List<Vertex> unprocessed)
        {
            int leastDistance = int.MaxValue;
            Vertex lowestDistanceNode = null;

            foreach (var vertex in unprocessed)
            {
                if (vertex.Distance < leastDistance)
                {
                    leastDistance = vertex.Distance;
                    lowestDistanceNode = vertex;
                }
            }

            return lowestDistanceNode;
        }
    }
}
