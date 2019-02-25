using System;
using System.Collections.Generic;
using System.ComponentModel;
using DataStructures.CommonLibrary.Trees;
using DataStructures.Exercises;
using DataStructures.Exercises.AlgoExpert;

namespace DataStructures
{
    internal class Program
    {
        private static char[] count = new char[256];

        private static void getCharCountArray(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                var t = str[i];
                count[t]++;
            }
        }

        private static int firstNonRepeating(string str)
        {
            HashSet<string> t = new HashSet<string>();

            getCharCountArray(str);
            int index = -1, i;

            for (i = 0; i < str.Length; i++)
            {
                if (count[str[i]] == 1)
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        private static void Main(string[] args)
        {
            AlgoExpertSubArraySort.Sort(new []{ 1, 2, 4, 7, 10, 11, 7, 12, 6, 7, 16, 18, 19 });
            AlgoExpertInsertSort.Sort(new[] { 8, 5, 2, 9, 5, -1, 45, 6, 3 });
            AlgoExpertSelectionSort.Sort(new [] { 8, 5, 2, 9, 5, -1,45, 6, 3 });
            AlgoExpertLru lru=new AlgoExpertLru(3);

            lru.Add(1,2);
            lru.Add(3,5);
            lru.Add(5,8);

            lru.Remove(3);
            lru.Add(10,58);
            lru.Add(11,59);
            lru.Add(12,59);
            var sum = AlgoExpertMaximumNonAdjacentSum.Sum(new[] {7, 10, 12, 7, 9, 14});

            AlgoExpertQuickSort.Run();

            var isBalanced = AlgoExpertBalancedBracket.IsBalanced("([])(){}(({))()()");

            var nthFibNumber = AlgoExperNthFibonacciNumber.Fib(6);

            var results = AlgoExpertSmallestDifference.FindSmallestDifference(new[] { -1, 5, 10, 20, 28, 3 },
                                                                    new[] { 4, 24, 134, 135, 15, 17 });

            AlgoExpertMinJumps.MinNumberOfJumps(new[] { 3, 4, 2, 1, 2, 3, 7, 1, 1, 1, 3 });
            AlgoExpertMinHeap minHeap = new AlgoExpertMinHeap();
            minHeap.Remove();

            AlgoExpertBreadthFirstSearch bfs = new AlgoExpertBreadthFirstSearch();

            var bfsResult = bfs.Bfs(new List<string>());

            AlgoExpertSuffixTree ast = new AlgoExpertSuffixTree();
            ast.From("babc");

            var strFound = ast.Contains("bbc");

            var root = new BinaryTreeNode(10);
            root.AddNode(5);
            root.AddNode(15);
            //root.AddNode(2);
            //root.AddNode(5);
            //root.AddNode(13);
            //root.AddNode(22);
            //root.AddNode(1);
            //root.AddNode(14);

            var isvalid = BinaryTree.ValidateBst(root);
            var result = BinaryTree.IterativeInOrderTraversal(root);

            var closestValue = FindCloseValueInBst.FindClosest(root, 3);

            Console.WriteLine(root);
        }

        private static void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}