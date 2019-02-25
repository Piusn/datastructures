using DataStructures.CommonLibrary.Trees;
using System;

namespace DataStructures.Exercises
{
    public class FindCloseValueInBst
    {
        public static BinaryTreeNode FindClosest(BinaryTreeNode root, int value)
        {
            int diff = Int32.MaxValue;
            BinaryTreeNode result = null;

            var current = root;
            while (current != null)
            {
                var tempDiff = Math.Abs(current.Data - value);

                if (tempDiff < diff)
                {
                    diff = tempDiff;
                    result = current;
                }
                if (current.Data == value)
                {
                    result = current;
                    break;
                }
                else if (current.Data < value)
                {
                    current = current.Right;
                }
                else
                {
                    current = current.Left;
                }
            }

            return result;
        }
    }
}