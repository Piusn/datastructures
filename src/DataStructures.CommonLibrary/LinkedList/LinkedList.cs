using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.CommonLibrary.LinkedList
{
    public class LinkedList<T>
    {
        public int Size { get; private set; }
        public LinkedListNode<T> Head { get; private set; }
        public LinkedListNode<T> Tail { get; set; }

        //add to head
        /// <summary>
        /// Complexity O(1)
        /// </summary>
        /// <param name="data"></param>
        public LinkedList<T> AddToHead(T data)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(data);

            // 1 -> 2  -> 3 - NULL

            if (Head == null) //this is the first node
            {
                Head = node;
                Tail = node;
                Size++;
                return this;
            }

            node.Next = Head;
            this.Head = node;

            Size++;

            if (Size == 1)
                this.Tail = Head;

            return this;
        }

        //add to tail
        public LinkedList<T> AddToTail(T data)
        {
            //1 -> 2 -> 3 - NULL
            LinkedListNode<T> node = new LinkedListNode<T>(data);

            if (Head == null)
            {
                Head = node;
                Tail = node;
                Size++;
                return this;
            }

            Tail.Next = node;
            Tail = node;
            Size++;

            return this;
        }
        
        //delete
        public void RemoveLast()
        {
            if (Head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            var current = Head;

            if (current.Next == null)
            {
                Head = null;
                return;
            }

            while (current != null && current.Next != null)
            {
                if (current.Next.Next == null)
                {
                    current.Next = null;
                }

                current = current.Next;
            }
        }
    }
}
