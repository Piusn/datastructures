
using DataStructures.CommonLibrary.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace DataStructures.Exercises
{
    public class LinkedListExercise
    {
        #region Check if a linked list of strings is palandromic

        //  AA -> XYZ -> CD -> C -> ZYX -> AA -> null
        public static bool IsPalandrome(CommonLibrary.LinkedList.SinglyLinkedListNode<string> head)
        {

            List<string> words = new List<string>();

            string forward = string.Empty;
            string backward = string.Empty;

            IsParandromeHelper(head, ref forward, ref backward);

            IsParandromeHelper(head, words);

            forward = string.Join("", words);
            var reversed = words.Select(ReverseString).Reverse();
            backward = string.Join("", reversed);

            return forward == backward;
        }

        private static string ReverseString(string str)
        {
            string temp = string.Empty;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                temp += str[i];
            }

            return temp;
        }

        private static string ReverseString(int index)
        {
            string temp = string.Empty;


            return temp;
        }

        private static void IsParandromeHelper(CommonLibrary.LinkedList.SinglyLinkedListNode<string> node, List<string> words)
        {
            //base
            if (node == null || string.IsNullOrEmpty(node.Data))
            {
                Console.WriteLine("done here");
            }
            else
            {
                words.Add(node.Data);
                IsParandromeHelper(node.Next, words);
            }
        }

        private static void IsParandromeHelper(CommonLibrary.LinkedList.SinglyLinkedListNode<string> node, ref string forward, ref string backward)
        {
            Console.WriteLine($"Forward: {forward}  Backward: {backward}");
            //base
            if (node.Next == null)
            {
                backward = backward + ReverseString(node.Data);
                forward = forward + node.Data;
                Console.WriteLine("done here");
            }
            else
            {
                forward = forward + node.Data;
                IsParandromeHelper(node.Next, ref forward, ref backward);

                backward = backward + ReverseString(node.Data);
            }
        }

        #endregion

        #region Detect loop in a linked list

        //1--->2---3
        //     |   |
        //     5---4

        /// <summary>
        /// Floyd’s Cycle-Finding Algorithm
        /// </summary>
        /// <param name="node">Node to look at</param>
        /// <returns>Boolean, true if a loop, else false</returns>
        public static bool IsLoop(DataStructures.CommonLibrary.LinkedList.SinglyLinkedListNode<int> node)
        {
            if (node == null)
                return false;

            if (node.Next == null)
                return false;

            bool isLoop = false;
            var first = node;
            var second = node.Next.Next;

            while (first.Next != null && second.Next?.Next != null)
            {
                if (first == second)
                {
                    isLoop = true;

                    break;
                }

                first = first.Next;
                second = second.Next.Next;
            }

            return isLoop;
        }
        #endregion

        #region Swap Kth node 
        public static void Swap(SinglyLinkedListNode<int> node, int k)
        {
            int leftCounter = 0;
            int rightCounter = 0;

            SwapHelper(node, ref rightCounter, ref leftCounter, k, null, null);
        }

        public static SinglyLinkedListNode<int> SwapHelper(SinglyLinkedListNode<int> node, ref int rightCounter, ref int leftCounter, int k, SinglyLinkedListNode<int> left, SinglyLinkedListNode<int> right)
        {
            if (node.Next == null)
            {
                return node;
            }
            else
            {
                leftCounter++;

                if (node.Next != null && k - leftCounter == 1)
                {
                    left = node;
                    node = node.Next;
                }
                else
                {
                    node = node.Next;
                }

                right = SwapHelper(node, ref rightCounter, ref leftCounter, k, left, right);

                rightCounter++;

                if (rightCounter - k == 1 && left != right)
                {
                    right = node;
                    //a -- b -- c -- d -- e --f

                    var l = left.Next;
                    var ln = left.Next.Next;
                    var r = right.Next.Next;

                    left.Next = right.Next;
                    left.Next.Next = ln;

                    right.Next = l;
                    right.Next.Next = r;

                }
            }

            return node;

        }

        #endregion

        #region Reverse Linked list
        // 1 -> 2 ->3 -> 4
        public static void Reverse(SinglyLinkedListNode<int> node)
        {
            SinglyLinkedListNode<int> prev = null;
            ReverseHelper(node, prev, ref node);
        }

        // 1 -> 2 ->3 -> 4
        public static void ReverseHelper(SinglyLinkedListNode<int> current, SinglyLinkedListNode<int> prev, ref SinglyLinkedListNode<int> head)
        {
            if (current.Next == null)
            {
                head = current;
                current.Next = prev;

                return;
            }
            else
            {
                //Get the next,
                var next = current.Next;

                //Invert the current to point to previous
                current.Next = prev;

                ReverseHelper(next, current, ref head);

            }
        }
        #endregion

        public static SinglyLinkedListNode<int> PairWiseSwap(SinglyLinkedListNode<int> head)
        {
            var third = head.Next.Next;

            head.Next.Next = head;
            head = head.Next;

            var current = head.Next;

            //a b c d e
            while (third != null)
            {
                if (third.Next == null)
                {
                    current.Next = third;
                    break;
                }

                if (third.Next.Next == null)
                {
                    //var v = third.Next;
                    current.Next = third.Next;
                    third.Next = null;
                    current.Next.Next = third;
                    break;
                }

                //
                var t = third.Next.Next;
                current.Next = third.Next;
                current.Next.Next = third;
                third = t;
                current = current.Next.Next;
            }

            return head;
        }
    }
}
