using System;
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
            DataStructures.CommonLibrary.LinkedList.LinkedListNode<int> first = new LinkedListNode<int>(1);
            DataStructures.CommonLibrary.LinkedList.LinkedListNode<int> second = new LinkedListNode<int>(2);
            DataStructures.CommonLibrary.LinkedList.LinkedListNode<int> third = new LinkedListNode<int>(3);
            DataStructures.CommonLibrary.LinkedList.LinkedListNode<int> fourth = new LinkedListNode<int>(4);
            DataStructures.CommonLibrary.LinkedList.LinkedListNode<int> fifth = new LinkedListNode<int>(5);

            first.Next = second;
            second.Next = third;
            third.Next = fourth;
            fourth.Next = fifth;
            fifth.Next = second;

            var isLoop = LinkedListExercise.IsLoop(first);
            
            Console.ReadKey();
            Console.WriteLine("Hello World!");
        }
    }
}
