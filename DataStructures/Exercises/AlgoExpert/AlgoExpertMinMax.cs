namespace DataStructures.Exercises.AlgoExpert
{
    public class AlgoExpertMinMaxLinkedListNode 
    {
        public AlgoExpertMinMaxLinkedListNode(int value, int min, int max) 
        {
            this.Max = max;
            this.Min = min;
            this.Value = value;
        }

        public int Value { get; set; }
        public AlgoExpertMinMaxLinkedListNode Next { get; set; }
        public AlgoExpertMinMaxLinkedListNode Previous { get; set; }

     
        public int Min { get; set; }
        public int Max { get; set; }
    }

    public class AlgoExpertMinMax
    {
        private AlgoExpertMinMaxLinkedListNode head = null;
        private AlgoExpertMinMaxLinkedListNode tail = null;

        public AlgoExpertMinMax()
        {
            Insert(1);
            Insert(34);
            Insert(19);

            var max = GetMax();
            var min = GetMin();

            Pop();

             max = GetMax();
             min = GetMin();
        }

        public int Peek()
        {
            return tail.Value;
        }

        public int GetMin()
        {
            return tail.Min;
        }

        public int GetMax()
        {
            return tail.Max;
        }

        public void Pop()
        {
            tail = tail.Previous;
            tail.Next = null;
        }

        public void Insert(int value)
        {
            if (head == null)
            {
                var node = new AlgoExpertMinMaxLinkedListNode(value, value, value);
                head = node;

                tail = node;
            }
            else
            {
                int max = tail.Max, min = tail.Min;

                if (value > tail.Max)
                    max = value;

                if (value < tail.Min)
                    min = value;

                var node = new AlgoExpertMinMaxLinkedListNode(value, min, max);
                tail.Next = node;
                node.Previous = tail;
                tail = node;
            }
        }
    }
}