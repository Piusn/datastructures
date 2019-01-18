using System;
using System.Collections.Generic;
using System.Text;
using DataStructures.CommonLibrary.Trees;

namespace DataStructures.Exercises
{
    public class ConvertBinaryToDoublyLinkedList
    {
        public static void Convert(BinaryTreeNode root)
        {
            Recurse(root);
        }

        private static BinaryTreeNode Recurse(BinaryTreeNode root)
        {
            if (root == null)
                return null;

            var left = Recurse(root.Left);
            var right = Recurse(root.Right);
            root.Left = root.Right = root;

            var result = Join(left, root);

            return root;
        }

        public static BinaryTreeNode Join(BinaryTreeNode head1, BinaryTreeNode head2)
        {
            if (head1 == null)
                return head2;

            if (head2 == null)
                return head1;

            BinaryTreeNode tail1 = head1.Left;
            BinaryTreeNode tail2 = head2.Left;

            tail1.Right = head2;
            head2.Left = tail1;

            head1.Left = tail2;
            tail2.Right = head1;

            return head1;
        }
    }
}
