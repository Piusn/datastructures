using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.CommonLibrary.Trees
{
    public class BinaryTreeNode
    {
        //Data
        public int Data { get; set; }

        //Left
        public BinaryTreeNode Left { get; set; }

        //Right
        public BinaryTreeNode Right { get; set; }

        public BinaryTreeNode Parent { get; set; }

        public BinaryTreeNode(int data)
        {
            this.Data = data;
        }

        private BinaryTreeNode AddNode(BinaryTreeNode data, BinaryTreeNode node)
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

            return data;
        }

        public virtual BinaryTreeNode AddNode(int data)
        {
            return AddNode(new BinaryTreeNode(data), this);
        }

        protected int Height(BinaryTreeNode node)
        {
            if (node == null)
                return 0;


            int left = 1 + Height(node.Left);
            int right = 1 + Height(node.Right);


            return Math.Max(left, right);
        }

        public int Height()
        {
            var height = Height(this);

            var left = this.Left != null ? 1 + Height(this.Left) : 0;
            var right = this.Right != null ? 1 + Height(this.Right) : 0;

            return Math.Max(left, right);
        }
    }

    public class NAryTreeNode<T>
    {
        public T Data { get; set; }
        public List<NAryTreeNode<T>> Children { get; set; }
        public int Count { get; set; }

        public NAryTreeNode<T> Parent { get; set; }

        public NAryTreeNode(T data)
        {
            this.Data = data;
            this.Children = new List<NAryTreeNode<T>>();
            this.Count = 1;
        }

        public NAryTreeNode<T> AddChild(T data)
        {
            NAryTreeNode<T> node = new NAryTreeNode<T>(data);
            node.Parent = this;
            this.Children.Add(node);
            this.Count += 1;

            return node;
        }
    }
}
