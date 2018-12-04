using System;
using DataStructures.CommonLibrary.LinkedList;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringPermutation.Permute("abcd");

            LinkedList<string> node = new LinkedList<string>();
            //AA->XYZ->CD->C->ZYX->AA-> null
            node.AddToHead("AA")
                .AddToTail("XRYZ")
                .AddToTail("CD")
                .AddToTail("C")
                .AddToTail("ZYX")
                .AddToTail("AA");

           var isParandrome= LinkedListExercise.IsPalandrome(node.Head);

            Console.ReadKey();
            Console.WriteLine("Hello World!");
        }
    }
}
