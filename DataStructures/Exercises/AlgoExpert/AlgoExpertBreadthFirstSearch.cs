using System.Collections.Generic;
using System.Linq;

namespace DataStructures.Exercises.AlgoExpert
{
    public class AlgoExpertBreadthFirstSearch
    {
        public DepthFirstSearch.Node root = null;

        public AlgoExpertBreadthFirstSearch()
        {
            root = new DepthFirstSearch.Node("A");
            var b = new DepthFirstSearch.Node("B");
            var c = new DepthFirstSearch.Node("C");
            var d = new DepthFirstSearch.Node("D");
            var e = new DepthFirstSearch.Node("E");
            var f = new DepthFirstSearch.Node("F");
            var g = new DepthFirstSearch.Node("G");
            var h = new DepthFirstSearch.Node("H");
            var i = new DepthFirstSearch.Node("I");
            var j = new DepthFirstSearch.Node("J");
            var k = new DepthFirstSearch.Node("K");

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

        public List<string> Bfs(List<string> visited)
        {
            var current = root;

            Queue<DepthFirstSearch.Node> queue = new Queue<DepthFirstSearch.Node>();
            queue.Enqueue(current);

            while (queue.Count > 0)
            {
                var dequeuedItem = queue.Dequeue();

                foreach (var dequeuedItemChild in dequeuedItem.Children)
                {
                    if (visited.All(x => x != dequeuedItemChild.Name))
                        queue.Enqueue(dequeuedItemChild);
                }

                visited.Add(dequeuedItem.Name);
            }

            return visited;
        }
    }
}