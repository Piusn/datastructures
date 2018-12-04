using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.CommonLibrary.LinkedList
{
    /// <summary>
    /// This is linked list node
    /// LinkedList node contains a data property and link to the next node
    /// </summary>
    public class LinkedListNode<T>
    {
        /// <summary>
        /// Data property
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// Next node 
        /// </summary>
        public LinkedListNode<T> Next { get; set; }

        public LinkedListNode(T data)
        {
            this.Data = data;
        }
    }
}
