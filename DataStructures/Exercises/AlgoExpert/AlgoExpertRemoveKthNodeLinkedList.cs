namespace DataStructures.Exercises.AlgoExpert
{
    public class AlgoExpertRemoveKthNodeLinkedList
    {
        public AlgoExpertRemoveKthNodeLinkedList()
        {
            AlgoExpertFindLoopLinkedListNode head     = new AlgoExpertFindLoopLinkedListNode(8);
            AlgoExpertFindLoopLinkedListNode nine     = new AlgoExpertFindLoopLinkedListNode(9);
            AlgoExpertFindLoopLinkedListNode ten      = new AlgoExpertFindLoopLinkedListNode(10);
            AlgoExpertFindLoopLinkedListNode eleven   = new AlgoExpertFindLoopLinkedListNode(11);
            AlgoExpertFindLoopLinkedListNode twelve   = new AlgoExpertFindLoopLinkedListNode(12);
            AlgoExpertFindLoopLinkedListNode thirteen = new AlgoExpertFindLoopLinkedListNode(13);
            AlgoExpertFindLoopLinkedListNode fourteen = new AlgoExpertFindLoopLinkedListNode(14);
            AlgoExpertFindLoopLinkedListNode fifteen = new AlgoExpertFindLoopLinkedListNode(15);
            AlgoExpertFindLoopLinkedListNode sixteen = new AlgoExpertFindLoopLinkedListNode(16);
            head.Next     = nine;
            nine.Next     = ten;
            ten.Next      = eleven;
            eleven.Next   = twelve;
            twelve.Next   = thirteen;
            thirteen.Next = fourteen;
            fourteen.Next = fifteen;
            fifteen.Next = sixteen;

            Remove(head,5);
        }
        public  void Remove(AlgoExpertFindLoopLinkedListNode head, int k)
        {
            var first = head;
            var second = head;

            int counter = 1;

            while (counter <= k)
            {
                second = second.Next;
                counter++;
            }

            if (second == null)
            {
                head = head.Next;
                return;
            }

            while (second.Next!=null )
            {
                first = first.Next;
                second = second.Next;
            }

            first.Next = first.Next.Next;
        }
    }
}