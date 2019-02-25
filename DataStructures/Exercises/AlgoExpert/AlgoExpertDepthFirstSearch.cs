using System.Collections;
using System.Collections.Generic;

namespace DataStructures.Exercises.AlgoExpert
{
    public class DepthFirstSearch
    {
        public class Node
        {
            public string Name { get; set; }
            public List<Node> Children { get; set; } = new List<Node>();

            public Node(string name)
            {
                this.Name = name;
            }

            public void AddChild(Node child)
            {
                this.Children.Add(child);
            }


            public void  PrintRucursive(List<Node> result)
            {
                if (!result.Contains(this))
                    result.Add(this);

                foreach (var rootChild in this.Children)
                {
                    rootChild.PrintRucursive(result);
                }

                //return result;
            }
        }

        public class DepthFirstSearchExercise
        {
            public Node root = null;

            public DepthFirstSearchExercise()
            {
                root = new Node("A");
                var b = new Node("B");
                var c = new Node("C");
                var d = new Node("D");
                var e = new Node("E");
                var f = new Node("F");
                var g = new Node("G");
                var h = new Node("H");
                var i = new Node("I");
                var j = new Node("J");
                var k = new Node("K");

                f.AddChild(i);
                f.AddChild(j);

                g.AddChild(k);

                b.AddChild(e);
                b.AddChild(f);

                d.AddChild(g);
                d.AddChild(h);

                root.AddChild(b);
                root.AddChild(c);
                root.AddChild(d);
            }



            public void Print(List<Node> result)
            {
                root.PrintRucursive(result);
                //Stack<Node> stack = new Stack<Node>();

                //stack.Push(root);

                //while (stack.Count > 0)
                //{
                //    var poppedItem = stack.Pop();

                //    result.Add(poppedItem);

                //    foreach (var poppedItemChild in poppedItem.Children)
                //    {
                //        if (!result.Contains(poppedItemChild))
                //        {
                //            if (poppedItemChild != null)
                //                stack.Push(poppedItemChild);
                //        }

                //    }
                //}
            }
        }
    }
}