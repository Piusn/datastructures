using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataStructures.CommonLibrary.Graph;

namespace DataStructures.Exercises
{
    public class GraphExercise
    {
        #region DFS

        public static void PrintNodeDfs(Graph graph)
        {
            Stack<Vertex> stack = new Stack<Vertex>();
            List<Vertex> visited = new List<Vertex>();
            stack.Push(graph.Vertexes[1]);

            while (stack.Count > 0)
            {
                var v = stack.Pop();
                if (!visited.Any(x => x.Id == v.Id))
                {
                    visited.Add(v);
                    Console.WriteLine(v.Id);

                    foreach (var vAdjacentNode in v.AdjacentNodes)
                    {
                        stack.Push(vAdjacentNode.Key);
                    }
                }
            }
        }


        #endregion

        #region BFS

        public static void PrintNodeBfs(Graph graph)
        {
            Queue<Vertex> queue = new Queue<Vertex>();
            List<Vertex> visited = new List<Vertex>();
            queue.Enqueue(graph.Vertexes[1]);

            while (queue.Count > 0)
            {
                var v = queue.Dequeue();
                if (!visited.Any(x => x.Id == v.Id))
                {
                    visited.Add(v);
                    Console.WriteLine(v.Id);

                    foreach (var vAdjacentNode in v.AdjacentNodes)
                    {
                        queue.Enqueue(vAdjacentNode.Key);
                    }
                }
            }
        }


        #endregion

        #region Find friends circles

        public static int FindCircleNum(int[,] m)
        {
            int rows = m.GetLength(0);
            int cols = m.GetLength(1);

            var visited = new int[rows];

            int count = 0;
            for (int i = 0; i < rows; i++)
            {
                if (visited[i] == 0)
                {
                    FindCircleNumHelper(m, visited, i, cols);
                    count += 1;
                }
            }

            return count;
        }

        public static void FindCircleNumHelper(int[,] m, int[] v, int row, int colCount)
        {
            for (int i = 0; i < colCount; i++)
            {
                if (m[row, i] == 1 && v[i] == 0)
                {
                    v[i] = 1;
                    FindCircleNumHelper(m, v, i, colCount);
                }
            }
        }

        #endregion
    }
}
