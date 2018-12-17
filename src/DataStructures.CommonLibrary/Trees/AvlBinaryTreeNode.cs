using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.CommonLibrary.Trees
{
    public class AvlBinaryTreeNode
    {
        //Data
        public int Data { get; set; }

        //Left
        public AvlBinaryTreeNode Left { get; set; }

        //Right
        public AvlBinaryTreeNode Right { get; set; }

        public AvlBinaryTreeNode Parent { get; set; }

        public AvlBinaryTreeNode(int data)
        {
            this.Data = data;
        }

        private AvlBinaryTreeNode AddNode(AvlBinaryTreeNode data, AvlBinaryTreeNode node)
        {
            // Go left
            if (data.Data < node.Data)
            {
                if (node.Left == null)
                {
                    node.Left = data;
                    data.Parent = node;
                }
                else
                {
                    AddNode(data, node.Left);
                }
            }

            //Go right
            if (data.Data > node.Data)
            {
                if (node.Right == null)
                {
                    node.Right = data;
                    data.Parent = node;
                }
                else
                {
                    AddNode(data, node.Right);
                }
            }

            var current = data.Parent;

            UnbalancedNode(current);

            return data;
        }

        public AvlBinaryTreeNode AddNode(int data)
        {
            return AddNode(new AvlBinaryTreeNode(data), this);
        }

        protected int Height(AvlBinaryTreeNode node)
        {
            if (node == null)
                return 0;

            int left = 1 + Height(node.Left);
            int right = 1 + Height(node.Right);

            return Math.Max(left, right);
        }


        public int UnbalancedNode(AvlBinaryTreeNode node)
        {
            var left = node.Left != null ? Height(node.Left) : 0;
            var right = node.Right != null ? Height(node.Right) : 0;

            var bf1 = left - right;

            var bf = Math.Abs(bf1);

            if (bf > 1)
            {
                if (bf1 < 0)
                {
                    if (node.Right.Right != null)
                    {
                        node = RotateLeft(node);
                    }
                }


                if (bf1 > 0)
                {
                    if (node.Left.Left != null)
                    {
                        RotateRight(node);
                    }
                }

            }

            if (node.Parent == null)
                return 0;

            UnbalancedNode(node.Parent);


            return 0;
        }

        public AvlBinaryTreeNode RotateLeft(AvlBinaryTreeNode node)
        {
            //10
            //   12
            //       25
            //          48
            //

            //Rotate at 12

            //10
            var nodeParent = node.Parent;

            //25
            var nodeRightChild = node.Right;

            //NULL
            var nodeLeftChild = node.Left;

            //10 - > 25
            nodeParent.Right = nodeRightChild;
            nodeRightChild.Parent = nodeParent;

            //25 - >12 left
            nodeRightChild.Left = node;
            node.Right = null;
            node.Parent = nodeRightChild;

            //Left child of the right child becomes the right child of the 12
            if (nodeRightChild.Left == null)
            {
                node.Right = nodeRightChild.Left;
                nodeRightChild.Parent = node;

                nodeRightChild.Left = null;
            }

            return nodeParent.Right;
        }

        private void RotateRight(AvlBinaryTreeNode node)
        {
            if (node == null)
                return;

            var nodeParent = node.Parent;
            var nodeRightChild = node.Right;
            var nodeLeftChild = node.Left;
            var nodeLeftRightChild = node.Left?.Right;

            //Parent now should point to the left child
            nodeParent.Left = nodeLeftChild;

            //Change parent for  the left chidl
            nodeLeftChild.Parent = nodeParent;

            //Current node goes to the left of the nodeLeftChild
            nodeLeftChild.Right = node;
            node.Parent = nodeLeftChild;

            //nodeLeftChild right child becomes left child of node
            node.Left = nodeLeftRightChild;
            nodeLeftRightChild.Parent = node;

        }


    }
}
