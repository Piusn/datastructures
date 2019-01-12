using DataStructures.CommonLibrary.Trees;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures.Exercises
{
    public class BinaryTree
    {
        #region Construct a Cartesian Tree from In-order Traversal

        //9,3,7,1,8,12,10,20,15,18,5
        //              i
        public static BinaryTreeNode Construct(int[] arr)
        {
            var root = ConstructHelper(arr, 0, arr.Length - 1);
            return root;
        }

        private static BinaryTreeNode ConstructHelper(int[] arr, int start, int end)
        {
            BinaryTreeNode node = null;

            if (start > end)
            {
                return null;
            }
            else
            {
                var max = Max(start, end, arr);

                var value = arr[max];

                node = new BinaryTreeNode(value);

                node.Left = ConstructHelper(arr, start, max - 1);
                node.Right = ConstructHelper(arr, max + 1, end);
            }

            return node;
        }

        private static int Max(int start, int end, int[] arr)
        {
            int index = start;
            int maxValue = arr[start];

            for (int i = start; i <= end; i++)
            {
                if (arr[i] < maxValue)
                {
                    index = i;
                    maxValue = arr[i];
                }
            }

            return index;
        }

        #endregion

        #region Inorder

        public static void InOrderTraversal(BinaryTreeNode node)
        {
            if (node.Left != null)
                InOrderTraversal(node.Left);

            Console.Write(node.Data + " ,");

            if (node.Right != null)
                InOrderTraversal(node.Right);
        }

        #endregion

        #region Least common Ancestor

        public static BinaryTreeNode FindLeastCommonAncestor(BinaryTreeNode node, int left, int right)
        {
            var previousLeastCommonAncestor = node;

            while (node != null)
            {
                previousLeastCommonAncestor = node;
                if ((left < node.Data && right > node.Data) || (right < node.Data && left > node.Data))
                {
                    break;
                }

                if (node.Data < left && node.Data < right)
                {
                    node = node.Right;
                }
                else if (node.Data > left && node.Data > right)
                {
                    node = node.Left;
                }
            }

            return previousLeastCommonAncestor;
        }

        #endregion

        #region Print in zigzag

        public static void ZigzagLevelOrder(BinaryTreeNode root)
        {
            IList<IList<int>> data = new List<IList<int>>();


            List<BinaryTreeNode> children = new List<BinaryTreeNode>() { root };
            ZigzagLevelOrderHelper(children, true, ref data);
        }

        private static void ZigzagLevelOrderHelper(List<BinaryTreeNode> children, bool reverse, ref IList<IList<int>> data)
        {
            List<BinaryTreeNode> currentChildren = new List<BinaryTreeNode>();

            var items = new List<int>();

            if (!children.Any())
            {
                return;
            }
            else
            {
                foreach (var item in children)
                {
                    if (item.Right != null)
                        currentChildren.Add(item.Right);

                    if (item.Left != null)
                        currentChildren.Add(item.Left);
                }

                if (reverse)
                {
                    children.Reverse();
                    items = children.Select(x => x.Data).ToList();
                    data.Add(items);
                }
                else
                {
                    items = children.Select(x => x.Data).ToList();
                    data.Add(items);
                }

                ZigzagLevelOrderHelper(currentChildren, !reverse, ref data);
            }
        }



        #endregion

        #region Binary Tree Maximum Path Sum

        public static int MaximumPathSum(BinaryTreeNode node)
        {
            int result = 0;

            MaximumPathHelper(node, ref result);

            return result;
        }

        public static int MaximumPathHelper(BinaryTreeNode node, ref int result)
        {
            if (node == null)
                return 0;

            //go left
            var leftSum = MaximumPathHelper(node.Left, ref result);
            var rightSum = MaximumPathHelper(node.Right, ref result);

            var maxOfRightLeft = Math.Max(leftSum, rightSum);

            var max = Math.Max(node.Data + maxOfRightLeft, node.Data + leftSum + rightSum);

            return Math.Max(max, max + result);
        }

        #endregion

        public static bool AreIdentical(BinaryTreeNode left, BinaryTreeNode right)
        {
            var identical = AreIdenticalHelper(left, right);

            return identical;
        }

        public static bool AreIdenticalHelper(BinaryTreeNode left, BinaryTreeNode right)
        {
            if (left == null && right == null)
                return true;

            if (left != null && right != null)
                return left.Data == right.Data && AreIdenticalHelper(left.Left, right.Left) && AreIdenticalHelper(left.Right, right.Right);

            return false;
        }

        public static void IterativeInOrderTraversal(BinaryTreeNode root)
        {
            Stack<BinaryTreeNode> stack = new Stack<BinaryTreeNode>();

            bool goLeft = false;
            stack.Push(root);
            var current = root.Left;

            while (stack.Count > 0 || goLeft)
            {
                while (current != null)
                {
                    stack.Push(current);
                    current = current.Left;
                }

                goLeft = false;

                while (stack.Count > 0 && !goLeft)
                {
                    var top = stack.Pop();
                    Console.WriteLine(top.Data);

                    if (top.Right != null)
                    {
                        current = top.Right;
                        //stack.Push(current);
                        goLeft = true;
                    }
                }
            }
        }
    }
}
