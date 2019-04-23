using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Exercises.AlgoExpert
{
    public class AlgoExpertBSTTraversal
    {
        public AlgoExpertBSTTraversal()
        {
            var root = new AlgoExpertInvertBinaryTreeNode(10);
            root.Add(16);
            root.Add(8);
            root.Add(7);
            root.Add(9);
            root.Add(17);
            root.Add(14);
            root.Add(15);
            root.Add(13);


            var result1 = InOrderTraverse(root,new List<int>());
            var result2 = PreOrderTraverse(root, new List<int>());
            var result3 = PostOrderTraverse(root, new List<int>());
        }

        public  List<int> InOrderTraverse(AlgoExpertInvertBinaryTreeNode tree, List<int> array)
        {
            if (tree == null)
                return array;

            InOrderTraverse(tree.Left, array);
            array.Add(tree.Data);
            InOrderTraverse(tree.Right, array);

            return array;
        }

        public static List<int> PreOrderTraverse(AlgoExpertInvertBinaryTreeNode tree, List<int> array)
        {
            // Write your code here.
            if (tree == null)
                return array;

            array.Add(tree.Data);
            PreOrderTraverse(tree.Left, array);
            PreOrderTraverse(tree.Right, array);

            return array;
        }

        public static List<int> PostOrderTraverse(AlgoExpertInvertBinaryTreeNode tree, List<int> array)
        {
            // Write your code here.
            if (tree == null) return array;
            PostOrderTraverse(tree.Left, array);
            PostOrderTraverse(tree.Right, array);
            array.Add(tree.Data);
            return array;
        }
    }
}
