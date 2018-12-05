using System;
using DataStructures.CommonLibrary.LinkedList;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringPermutation.Permute("abcd");

            //LinkedList<string> node = new LinkedList<string>();
            //AA->XYZ->CD->C->ZYX->AA-> null
            // node.AddToHead("AA")
            //     .AddToTail("XYZ")
            //     .AddToTail("CD")
            //     .AddToTail("C")
            //     .AddToTail("ZYX")
            //     .AddToTail("AA");

            //var isParandrome= LinkedListExercise.IsPalandrome(node.Head);

            BacktrackingCharacterMatrix.FindWord("START");
            BacktrackingCharacterMatrix.FindWord("NOTE");
            BacktrackingCharacterMatrix.FindWord("SAND");
            BacktrackingCharacterMatrix.FindWord("STONED");
            Console.ReadKey();
            Console.WriteLine("Hello World!");
        }
    }
}
