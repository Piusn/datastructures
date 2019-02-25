using DataStructures.CommonLibrary.Trees;
using System;

namespace DataStructures.Exercises
{
    public class FindMaxPathSumInBinaryTree
    {
        private static int CurrentMax = int.MinValue;

        public static int FindMaxSumPath(BinaryTreeNode root)
        {
            var pathSum = FindMaxSumPathHelper(root);

            return pathSum;
        }

        private static int FindMaxSumPathHelper(BinaryTreeNode node)
        {
            if (node == null)
                return 0;

            var left = FindMaxSumPathHelper(node.Left);
            var right = FindMaxSumPathHelper(node.Right);

            var subTreeSub = left + node.Data + right;

            if (subTreeSub > CurrentMax)
                CurrentMax = subTreeSub;

            return Math.Max(left, right) + node.Data;
        }
    }
}
