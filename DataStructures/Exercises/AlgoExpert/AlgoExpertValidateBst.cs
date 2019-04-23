using DataStructures.CommonLibrary.Trees;
using System;

namespace DataStructures.Exercises.AlgoExpert
{
    public class AlgoExpertValidateBst
    {
        public static bool ValidateBst(BinaryTreeNode root)
        {
            return ValidateBst(root, Int32.MinValue, int.MaxValue);
        }

        private static bool ValidateBst(BinaryTreeNode node, int min, int max)
        {
            if (node == null)
                return true;

            if (node.Data < min || node.Data >= max)
                return false;

            return ValidateBst(node.Left, min, node.Data) &&
                   ValidateBst(node.Right, node.Data, max);
        }
    }
}