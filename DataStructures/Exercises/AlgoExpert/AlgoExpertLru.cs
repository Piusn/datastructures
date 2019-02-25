using System.Collections.Generic;

namespace DataStructures.Exercises.AlgoExpert
{
    public class AlgoExpertLruLinkedListNode
    {
        public int Data { get; set; }
        public int Key { get; set; }
        public AlgoExpertLruLinkedListNode Next { get; set; }
        public AlgoExpertLruLinkedListNode Previous { get; set; }

        public AlgoExpertLruLinkedListNode(int data, int key)
        {
            Data = data;
            Key = key;
        }
    }

    public class AlgoExpertLru
    {
        private Dictionary<int, AlgoExpertLruLinkedListNode> cache = new Dictionary<int, AlgoExpertLruLinkedListNode>();

        private AlgoExpertLruLinkedListNode Head { get; set; }
        private AlgoExpertLruLinkedListNode Tail { get; set; }

        public int Capacity { get; private set; }

        public AlgoExpertLru(int capacity)
        {
            this.Capacity = capacity;
        }

        //add
        public void Add(int key, int value)
        {
            AlgoExpertLruLinkedListNode node = new AlgoExpertLruLinkedListNode(value, key);

            if (cache.Count == Capacity)
            {
                var tail = Tail;

                if (Tail != null)
                    Tail = Tail.Previous;

                cache.Remove(tail.Key);
            }

            if (Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
                return;
            }

            node.Next = Head;
           
            Head.Previous = node;
            Head = node;

            if (Tail == null)
            {
                Tail = node;
            }

            cache.Add(key, node);
        }

        //remove
        public void Remove(int key)
        {
            if (!cache.ContainsKey(key))
                throw new KeyNotFoundException(nameof(key));

            var objectRef = cache[key];

            if (objectRef.Next != null && objectRef.Previous != null)
            {
                objectRef.Previous.Next = objectRef.Next;
                objectRef.Next.Previous = objectRef.Previous;
            }
            else if (Head == objectRef)
            {
                Head = Head.Next;
            }
            else if (Tail == objectRef)
            {
                Tail = Tail.Previous;
            }
        }

        //get
        public AlgoExpertLruLinkedListNode Get(int key)
        {
            if (!cache.ContainsKey(key))
                throw new KeyNotFoundException(nameof(key));

            var objectRef = cache[key];

            if (objectRef == Head)
            {
                return objectRef;
            }
            else if (objectRef.Next != null && objectRef.Previous != null)
            {
                objectRef.Previous.Next = objectRef.Next;
                objectRef.Next.Previous = objectRef.Previous;
            }
            else if (objectRef == Tail)
            {
                Tail = objectRef.Previous;
                Tail.Next = null;

                objectRef.Next = Head;
                objectRef.Previous = null;
                Head = objectRef;
            }

            return objectRef;
        }
    }
}