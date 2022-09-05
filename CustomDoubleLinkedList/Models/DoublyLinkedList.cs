using CustomDoubleLinkedList.Extensions;

namespace CustomDoubleLinkedList.Models
{
    public class DoublyLinkedList
    {
        public Node Head;

        public Node First => Head;

        public Node Last
        {
            get
            {
                Node node = Head.GetLastNode();
                return node;
            }

        }

        public Node Next => Head.Next;
        public Node Previous => Head.Previous;

    }
}
