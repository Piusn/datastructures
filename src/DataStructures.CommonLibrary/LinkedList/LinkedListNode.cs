using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.CommonLibrary.LinkedList
{
    /// <summary>
    /// This is linked list node
    /// LinkedList node contains a data property and link to the next node
    /// </summary>
    public class LinkedListNode
    {
        /// <summary>
        /// Data property
        /// </summary>
        public int Data { get; set; }

        /// <summary>
        /// Next node 
        /// </summary>
        public LinkedListNode Next { get; set; }

        public LinkedListNode(int data)
        {
            this.Data = data;
        }
    }
}
