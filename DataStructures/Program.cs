using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using DataStructures.Algorithms;
using DataStructures.CommonLibrary.LinkedList;
using DataStructures.CommonLibrary.Trees;
using DataStructures.Exercises;

namespace DataStructures
{
    class Program
    {
        static char[] count = new char[256];

        static void getCharCountArray(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {

                var t = str[i];
                count[t]++;
            }
        }

        static int firstNonRepeating(string str)
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

        static void Main(string[] args)
        {
            StringExercise.BooyeMooreHotspool("TRUSTHARDTOOTHBRUSHES","TOOTH");
            NumberExercise.PrintLargestSumSubArray(new int[]{-4,2,5,-10,5,1} );
            LruCache cache=new LruCache();
            cache.Add(1,45);
            cache.Add(2, 46);
            cache.Add(3, 47);
            cache.Add(4, 48);
            cache.Get(2);
            cache.Add(5, 49);
            cache.Add(6, 50);

           
            BinaryTreeNode binaryTreeNode = new BinaryTreeNode(10);
            binaryTreeNode.AddNode(15);
            binaryTreeNode.AddNode(7);
            binaryTreeNode.AddNode(3);
            binaryTreeNode.AddNode(25);
            binaryTreeNode.AddNode(48);
            binaryTreeNode.AddNode(72);
            binaryTreeNode.AddNode(81);
            binaryTreeNode.AddNode(43);
            binaryTreeNode.AddNode(31);
            BinaryTree.IterativeInOrderTraversal(binaryTreeNode);
            BinaryTreeNode binaryTreeNode1 = new BinaryTreeNode(10); ;
            binaryTreeNode1.AddNode(15);
            binaryTreeNode1.AddNode(7);
            binaryTreeNode1.AddNode(3);
            binaryTreeNode1.AddNode(25);
            binaryTreeNode1.AddNode(48);
            binaryTreeNode1.AddNode(72);
            binaryTreeNode1.AddNode(81);
            binaryTreeNode1.AddNode(43);
            binaryTreeNode1.AddNode(31);
          //  binaryTreeNode1.AddNode(5555);

            BinaryTree.AreIdentical(binaryTreeNode, binaryTreeNode1);

            StringExercise.FindAllParandrome("aabbbaa");
            NumberExercise.DynamicCoinChange(new[] { 1, 2, 3 }, 4);

            StringExercise
               .XmlToTree("<xml><data>hello world     </data>    <a><b></b><b><c></c></b></a></xml>");

            var newString = StringExercise.RemoveWhiteSpaces("  this  .");

            var input = new[] {1,2,3,4,5,6,7,8,9};
            var lowHigh = new int[] {1, 2, 5, 5, 5, 5, 5, 7, 9};
            ArrayExercise.FindLowHighIndex(lowHigh);

            ArrayExercise.ReverseArray(input,3);

            DynamicProgramming.Run();

            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += Worker_DoWork;

            RecursionExercise.TowerOfHanoi(3, "A", "C", "B");
            var items = RecursionExercise.GetNumbers(100);
            RecursionExercise.TowerOfHanoi(3, "A", "B", "C");


            int[] a = new[] { 1, 5, 2, 4, 6 };
            //int x1 = a[0];
            //int x2 = 1;
            //int n = 5;

            //var two = 1 ^ 4;

            //for (int i = 1; i < 5; i++)
            //{
            //    x1 = x1 ^ a[i];
            //}

            //for (int i = 2; i <= n+1; i++)
            //{
            //    x2 = x2 ^ i;
            //}

            //int missing = x1 ^ x2;

            //var sorted = ArrayExercise.IsSorted(new[] {2, 3, 4,5,5 ,6 ,7}, 1);

            //var patternFound = StringExercise.FindSubstringBruteForce("adabcrtruk", "rtru");

            //HeapSort.Sort(new[] { 20, 13, 9, 8, 5, 3, 7, 6, 2, 1, 56, 789, 22, 54, 123 });
            //var median = NumberExercise.FindMeanOfTwoSortedArrays(new[] { 3, 4 }, new[] { 1, 2 });
            //Console.WriteLine(median);
            // var i = NumberExercise.ConvertRomanToInteger("MCMXCIV");

            //  var counter = NumberExercise.CoinChange(new[] {100, 50, 20, 10}, 280);
            // Console.WriteLine(i);
            //int num = 3;
            //num = num << 1;
            //num = num >> 2;

            //var strin = "1235";

            //var strArray = strin.ToCharArray();
            //double result = 0;
            //double idx = 0;

            //for (int i = 0; i < strArray.Length; i++)
            //{
            //    var c = strArray[i];
            //    var numericValue = char.GetNumericValue(c);

            //    result = result * 10 + numericValue;


            //    idx++;

            //}

            //Console.WriteLine(result);
            //  Hashtable table = new Hashtable();
            //  table.Add('a', 1);
            //  var t=table['a'];
            //  table.Add('a', 1);
            //  var node = BinaryTree.Construct(new[] { 9, 3, 7, 1, 8, 12, 10, 20, 15, 18, 5 });
            // BinaryTree.ZigzagLevelOrder(node);
            //var lca=  BinaryTree.FindLeastCommonAncestor(node, 15, 10);

            //  BFS.Bfs(node);
            //  BinaryTree.InOrderTraversal(node);

            //  int i = 9;

            //StringExercise.ReverseString("Pius");
            //StringExercise.FindEqualSumDigits(55033);
            //string str = "geeksforgeeks";
            //int index = firstNonRepeating(str);
            //Binary Tree
            //BinaryTreeNode binaryTreeNode = new BinaryTreeNode(10);
            //binaryTreeNode.AddNode(15);
            //binaryTreeNode.AddNode(7);
            //binaryTreeNode.AddNode(3);
            //binaryTreeNode.AddNode(25);
            //binaryTreeNode.AddNode(48);
            //binaryTreeNode.AddNode(72);
            //binaryTreeNode.AddNode(81);
            //binaryTreeNode.AddNode(43);
            //binaryTreeNode.AddNode(31);

            //var height = binaryTreeNode.Height();
            //Console.WriteLine($"Height {height}");


            //AvlBinaryTreeNode binaryTreeNode = new AvlBinaryTreeNode(10);
            //binaryTreeNode.AddNode(15);
            //binaryTreeNode.AddNode(7);
            //binaryTreeNode.AddNode(3);
            //binaryTreeNode.AddNode(25);
            //binaryTreeNode.AddNode(48);
            //binaryTreeNode.AddNode(72);
            //binaryTreeNode.AddNode(81);
            //binaryTreeNode.AddNode(43);
            //binaryTreeNode.AddNode(31);

            //var height = binaryTreeNode.Height();
            //Console.WriteLine($"Height {height}");

            //----------------------------------------------------------------
            //StringPermutation.Permute("abcd");
            //-----------------------------------------------------------------
            //LinkedList<string> node = new LinkedList<string>();
            //AA->XYZ->CD->C->ZYX->AA-> null
            // node.AddToHead("AA")
            //     .AddToTail("XYZ")
            //     .AddToTail("CD")
            //     .AddToTail("C")
            //     .AddToTail("ZYX")
            //     .AddToTail("AA");

            //var isParandrome= LinkedListExercise.IsPalandrome(node.Head);
            //----------------------------------------------------------------
            //BacktrackingCharacterMatrix.FindWord("START");
            //BacktrackingCharacterMatrix.FindWord("NOTE");
            //BacktrackingCharacterMatrix.FindWord("SAND");
            //BacktrackingCharacterMatrix.FindWord("STONED");
            //----------------------------------------------------------------
            //DataStructures.CommonLibrary.LinkedList.SinglyLinkedListNode<int> first = new SinglyLinkedListNode<int>(1);
            //DataStructures.CommonLibrary.LinkedList.SinglyLinkedListNode<int> second = new SinglyLinkedListNode<int>(2);
            //DataStructures.CommonLibrary.LinkedList.SinglyLinkedListNode<int> third = new SinglyLinkedListNode<int>(3);
            //DataStructures.CommonLibrary.LinkedList.SinglyLinkedListNode<int> fourth = new SinglyLinkedListNode<int>(4);
            //DataStructures.CommonLibrary.LinkedList.SinglyLinkedListNode<int> fifth = new SinglyLinkedListNode<int>(5);

            //first.Next = second;
            //second.Next = third;
            //third.Next = fourth;
            //fourth.Next = fifth;
            //var response = LinkedListExercise.PairWiseSwap(first);


            ////  fifth.Next = second;
            //LinkedListExercise.Reverse(first);
            //LinkedListExercise.Swap(first, 2);

            //var isLoop = LinkedListExercise.IsLoop(first);

            //----------------------------------------------------------------

            //var input = new int[] { 123,6,44, 4, 5,150, 1,789, 9, 7, 3,6,89 };
            //new  QuickSort().Sort(input, 0, input.Length-1);


            //----------------------------------------------------------------
            // MatrixExercise.PrintArrayInSpiralRecursive();

            Console.ReadKey();
            Console.WriteLine("Hello World!");
        }

        private static void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
