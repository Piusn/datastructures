namespace DataStructures.CommonLibrary.LinkedList
{
    public class DoublyLinkedListNode<T>
    {
        /// <summary>
        /// Data property
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// Next node 
        /// </summary>
        public DoublyLinkedListNode<T> Next { get; set; }
        public DoublyLinkedListNode<T> Previous { get; set; }

        public DoublyLinkedListNode(T data)
        {
            this.Data = data;
        }
    }
}
