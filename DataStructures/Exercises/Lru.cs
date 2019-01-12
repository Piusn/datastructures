using System;
using System.Collections.Generic;
using System.Text;
using DataStructures.CommonLibrary.LinkedList;

namespace DataStructures.Exercises
{
    public class LruCache
    {
        public static Dictionary<int, DoublyLinkedListNode<int>> cache = new Dictionary<int, DoublyLinkedListNode<int>>();

        private static DoublyLinkedListNode<int> Head = null;
        private static DoublyLinkedListNode<int> Tail = null;

        private static int Count = 0;

        public void Add(int key, int data)
        {
            if (Head == null)
            {
                var node = new DoublyLinkedListNode<int>(data);
                Head = node;
                Tail = Head;
            }
            else
            {
                if (Count == 4)
                {
                    Head = Head.Next;
                    cache[key] = Head;
                }

                var current = Head.Next;
                var previous = Head;

                while (current != null)
                {
                    if (current.Next == null)
                        previous = current;

                    current = current.Next;
                }

                current = new DoublyLinkedListNode<int>(data);
                cache[key] = current;

                previous.Next = current;

                Tail = current;
                current.Previous = previous;
            }
            if (Count < 4)
                Count += 1;
        }

        public void Get(int key)
        {
            var node = cache[key];
            if (node == null)
            {
                Console.WriteLine("The key is not found");
                return;
            }

            var previous = node.Previous;

            if (previous != null)
            {
                previous.Next = node.Next;
                if (node.Next != null)
                    node.Next.Previous = previous;
            }

            Tail.Next = node;
            node.Previous = Tail;

            node.Next = null;
            Tail = node;
        }
    }
}
