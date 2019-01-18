using DataStructures.CommonLibrary.Trees;

namespace DataStructures.Exercises
{
    public class CheckForBalancedBinaryTree
    {
        public static bool IsBalanced(BinaryTreeNode root)
        {
            if (root == null)
                return true;
            return IsBalancedHelper(root);
        }

        private static bool IsBalancedHelper(BinaryTreeNode root)
        {
            BinaryTreeNode prev = null;

            if (root == null)
                return true;

            if (!IsBalancedHelper(root.Left))
                return false;

            prev = root;

            if (root.Data > prev.Data)
                return false;

            if (!IsBalancedHelper(root.Right))
                return false;

            return true;
        }
    }
}
