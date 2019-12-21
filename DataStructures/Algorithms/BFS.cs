using System;
using System.Collections.Generic;
using System.Text;
using DataStructures.CommonLibrary.Trees;

namespace DataStructures.Algorithms
{
    public class BreadthFirstSearch
    {
        public static void Bfs(BinaryTreeNode root)
        {
            //print root
            //go left

            Queue<BinaryTreeNode> queue = new Queue<BinaryTreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();

                Console.WriteLine(node.Data);

                if (node.Left != null)
                    queue.Enqueue(node.Left);

                if (node.Right != null)
                    queue.Enqueue(node.Right);
            }
        }
    }
}
