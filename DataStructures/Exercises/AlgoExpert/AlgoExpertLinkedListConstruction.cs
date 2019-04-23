namespace DataStructures.Exercises.AlgoExpert
{
    public class AlgoExpertLinkedListConstruction
    {
        public AlgoExpertFindLoopLinkedListNode Head { get; set; }
        public AlgoExpertFindLoopLinkedListNode Tail { get; set; }

        public void SetHead(AlgoExpertFindLoopLinkedListNode node)
        {
            if (Head == null)
            {
                Head = node;

                //Tail
                Tail = node;
                return;
            }
            node.Next = Head;
            Head.Previous = node;

            Head = node;
        }

        public void SetTail(AlgoExpertFindLoopLinkedListNode node)
        {
            if (Tail != null)
            {
                Tail.Next = node;
                node.Previous = Tail;

                Tail = node;
            }
            else
            {
                Tail = node;
            }
        }
    }
}