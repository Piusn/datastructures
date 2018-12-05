
using System;
using System.Collections.Generic;
using System.Linq;
using LinkedListNode = DataStructures.CommonLibrary.LinkedList.LinkedListNode<string>;

namespace DataStructures
{
    public class LinkedListExercise
    {
        #region Check if a linked list of strings is palandromic

        //  AA -> XYZ -> CD -> C -> ZYX -> AA -> null
        public static bool IsPalandrome(CommonLibrary.LinkedList.LinkedListNode<string> head)
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

        private static void IsParandromeHelper(CommonLibrary.LinkedList.LinkedListNode<string> node, List<string> words)
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

        private static void IsParandromeHelper(CommonLibrary.LinkedList.LinkedListNode<string> node, ref string forward, ref string backward)
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
                IsParandromeHelper(node.Next,ref  forward,ref backward);

                backward = backward + ReverseString(node.Data);
            }
        }

        #endregion
    }
}
