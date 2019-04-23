namespace DataStructures.Exercises.AlgoExpert
{
    public class AlgoExpertFindLoopLinkedListNode
    {
        public int Value { get; set; }
        public AlgoExpertFindLoopLinkedListNode Next { get; set; }
        public AlgoExpertFindLoopLinkedListNode Previous { get; set; }

        public AlgoExpertFindLoopLinkedListNode(int value)
        {
            this.Value = value;
        }
    }

    public class AlgoExpertFindLoopLinkedList
    {
        public AlgoExpertFindLoopLinkedList()
        {
            AlgoExpertFindLoopLinkedListNode head = new AlgoExpertFindLoopLinkedListNode(8);
            AlgoExpertFindLoopLinkedListNode nine = new AlgoExpertFindLoopLinkedListNode(9);
            AlgoExpertFindLoopLinkedListNode ten = new AlgoExpertFindLoopLinkedListNode(10);
            AlgoExpertFindLoopLinkedListNode eleven = new AlgoExpertFindLoopLinkedListNode(11);
            AlgoExpertFindLoopLinkedListNode twelve = new AlgoExpertFindLoopLinkedListNode(12);
            AlgoExpertFindLoopLinkedListNode thirteen = new AlgoExpertFindLoopLinkedListNode(13);

            head.Next = nine;
            nine.Next = ten;
            ten.Next = eleven;
            eleven.Next = twelve;
            twelve.Next = thirteen;
            thirteen.Next = eleven;

            FindLoop(head);
        }

        public bool FindLoop(AlgoExpertFindLoopLinkedListNode head)
        {
            var slow = head.Next;
            var fast = head.Next.Next;

            bool hasLoop = false;

            while (slow != null && fast != null && fast.Next != null)
            {
                if (slow == fast)
                {
                    hasLoop = true;
                    break;
                }
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            slow = head;

            while (slow != null && fast != null)
            {
                if (slow == fast)
                    break;

                slow = slow.Next;
                fast = fast.Next;
            }
            return hasLoop;
        }
    }
}