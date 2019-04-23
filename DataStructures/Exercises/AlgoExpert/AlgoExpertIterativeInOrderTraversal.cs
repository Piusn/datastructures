using System;

namespace DataStructures.Exercises.AlgoExpert
{
    public class AlgoExpertIterativeInOrderTraversal
    {
        public static void Print(AlgoExpertInvertBinaryTreeNode root)
        {
            //previous
            //current

            AlgoExpertInvertBinaryTreeNode previous = null;
            AlgoExpertInvertBinaryTreeNode current = root;

            while (current != null)
            {
                //go left
                if (current.Left != null && current.Parent == previous)
                {
                    previous = current;
                    current = current.Left;
                    continue;
                }

                if (current.Left == null && current.Right == null)
                {
                    Console.WriteLine(current.Data);
                    previous = current;
                    current = current.Parent;
                    continue;
                }
              
                //Go right
                if (current.Right != null && current.Left == previous)
                {
                    Console.WriteLine(current.Data);
                    previous = current;
                    current = current.Right;
                    continue;
                }

                //Go up
                previous = current;
                current = current.Parent;
            }

            //if previous is null we are starting

            //If current is null we are ending

            //If previous is current parent and move left

            //if previous is current current child, and left child print current.

            //if previous is current child,right child keep moving up
        }
    }
}