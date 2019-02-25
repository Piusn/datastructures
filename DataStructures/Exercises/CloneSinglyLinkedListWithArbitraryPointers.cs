using DataStructures.CommonLibrary.LinkedList;

namespace DataStructures.Exercises
{
    public class CloneSinglyLinkedListWithArbitraryPointers
    {
        public static void Clone(SinglyLinkedListNode<int> head)
        {
            var current = head;

            while (current != null)
            {
                var temp = current.Next;
                current.Next = new SinglyLinkedListNode<int>(current.Data);
                current.Next.Next = temp;

                current = temp;
            }

            SinglyLinkedListNode<int> clone = null;
            SinglyLinkedListNode<int> cloneHead = null;

            current = head;

            while (current != null)
            {
                if (clone == null)
                {
                    clone = new SinglyLinkedListNode<int>(current.Next.Data);
                    cloneHead = clone;

                    if (current.Arbitrary != null)
                        cloneHead.Arbitrary = current.Arbitrary.Next;
                    else if (current.Arbitrary == current)
                        cloneHead.Arbitrary = clone;

                    current.Next = current.Next.Next;
                    current = current.Next;
                }
                else
                {
                    var temp = current.Next;
                    cloneHead.Next = temp;
                    cloneHead = cloneHead.Next;

                    if (current.Arbitrary != null)
                        cloneHead.Arbitrary = current.Arbitrary.Next;
                    else if (current.Arbitrary == current)
                        cloneHead.Arbitrary = cloneHead;

                    current.Next = temp?.Next;
                    current = current.Next;
                  //  cloneHead = cloneHead.Next;
                }
            }
        }
    }
}