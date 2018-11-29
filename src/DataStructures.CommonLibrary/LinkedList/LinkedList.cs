using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.CommonLibrary.LinkedList
{
    public class LinkedList
    {
        public LinkedListNode Head { get; set; }

        //add to head
        public void AddToHead(int data)
        {
            LinkedListNode node = new LinkedListNode(data);

            // 1 -> 2  -> 3 - NULL

            if (Head == null) //this is the first node
            {
                Head = new LinkedListNode(data);
                return;
            }

            node.Next = Head;
            this.Head = node;
        }

        //add to tail
        public void AddToTail(int data)
        {
            //1 -> 2 -> 3 - NULL
            LinkedListNode node = new LinkedListNode(data);

            if (Head == null)
            {
                Head = node;
                return;
            }

            var current = Head;

            while (current != null)
            {
                if (current.Next == null)
                {
                    current.Next = new LinkedListNode(data);
                    break;
                }

                current = current.Next;
            }
        }

        //add to middle

        //search

        //delete

    }
}
