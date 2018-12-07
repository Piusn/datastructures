using System;
using DataStructures.Algorithms;
using DataStructures.CommonLibrary.LinkedList;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
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
            //DataStructures.CommonLibrary.LinkedList.LinkedListNode<int> first = new LinkedListNode<int>(1);
            //DataStructures.CommonLibrary.LinkedList.LinkedListNode<int> second = new LinkedListNode<int>(2);
            //DataStructures.CommonLibrary.LinkedList.LinkedListNode<int> third = new LinkedListNode<int>(3);
            //DataStructures.CommonLibrary.LinkedList.LinkedListNode<int> fourth = new LinkedListNode<int>(4);
            //DataStructures.CommonLibrary.LinkedList.LinkedListNode<int> fifth = new LinkedListNode<int>(5);

            //first.Next = second;
            //second.Next = third;
            //third.Next = fourth;
            //fourth.Next = fifth;
            //fifth.Next = second;

            //var isLoop = LinkedListExercise.IsLoop(first);

            //----------------------------------------------------------------

            //var input = new int[] { 123,6,44, 4, 5,150, 1,789, 9, 7, 3,6,89 };
            //new  QuickSort().Sort(input, 0, input.Length-1);
            //----------------------------------------------------------------
            MatrixExercise.PrintArrayInSpiral();
            Console.ReadKey();
            Console.WriteLine("Hello World!");
        }
    }
}
