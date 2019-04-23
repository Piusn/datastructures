namespace DataStructures.Exercises.AlgoExpert
{
    public class AlgoExpertInvertBinaryTreeNode
    {
        public int Data { get; set; }
        public AlgoExpertInvertBinaryTreeNode Left { get; set; }
        public AlgoExpertInvertBinaryTreeNode Right { get; set; }
        public AlgoExpertInvertBinaryTreeNode Parent { get; set; }

        public AlgoExpertInvertBinaryTreeNode(int data)
        {
            this.Data = data;
        }

        public AlgoExpertInvertBinaryTreeNode GetRightMin()
        {
            var current = this;

            while (current != null)
            {
                if (current.Left == null)
                    break;
                current = current.Left;
            }

            return current;
        }

        public void Add(int data)
        {
            var node = new AlgoExpertInvertBinaryTreeNode(data);
            var current = this;

            while (current != null)
            {
                //Insert to the left
                if (data <= current.Data && current.Left == null)
                {
                    current.Left = node;
                    node.Parent = current;
                    break;
                }

                //Insert right
                if (data > current.Data && current.Right == null)
                {
                    current.Right = node;
                    node.Parent = current;
                    break;
                }

                //if
                if (data < current.Data)
                    current = current.Left;
                else if (data >= current.Data)
                    current = current.Right;
            }
        }

        public AlgoExpertInvertBinaryTreeNode Find(int value)
        {
            AlgoExpertInvertBinaryTreeNode response = null;

            var current = this;

            while (current != null)
            {
                if (current.Data == value)
                {
                    response = current;
                    break;
                }

                current = value < current.Data ? current.Left : current.Right;
            }

            return response;
        }

        public void Remove(int value, AlgoExpertInvertBinaryTreeNode parent)
        {
            var current = this;

            while (current != null)
            {
                if (value < current.Data)
                {
                    current = current.Left;
                }
                else if (value > current.Data)
                {
                    current = current.Right;
                }
                else
                {
                    //Has both right and left
                    if (current.Left != null && current.Right != null)
                    {
                        parent = current;
                        current = current.Right.GetRightMin();
                        Remove(current.Data, current);
                        break;
                    }

                    if (current.Right != null && parent.Right == current)
                    {
                        parent.Right = current.Right;
                        break;
                    }

                    if (current.Left == null && current.Right == null && parent.Left == current)
                    {
                        parent.Left = current.Left;
                        break;
                    }
                }
            }
        }
    }

    public class AlgoExpertInvertBinaryTree
    {
        public AlgoExpertInvertBinaryTree()
        {
            var root=new AlgoExpertInvertBinaryTreeNode(10);
            root.Add(16);
            root.Add(8);
            root.Add(7);
            root.Add(9);
            root.Add(17);
            root.Add(14);
            root.Add(15);
            root.Add(13);

            InvertBinary(root);
        }

        public void InvertBinary(AlgoExpertInvertBinaryTreeNode root)
        {
            if (root == null)
                return;

            var left = root.Left;
            root.Left = root.Right;
            root.Right = left;

            InvertBinary(root.Left);
            InvertBinary(root.Right);
        }
    }
}