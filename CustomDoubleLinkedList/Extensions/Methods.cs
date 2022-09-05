using CustomDoubleLinkedList.Models;

namespace CustomDoubleLinkedList.Extensions
{
    public static class Methods
    {
        public static void Add (this DoublyLinkedList list, int data)
        {

            Node newNode = new Node(data);
            if(list.Head is null)
            {
                list.Head = newNode;
            }
            else
            {
                Node current= list.Head.GetLastNode();
                current.Next = newNode;
                newNode.Previous = current;
            }
        }

        /// <summary>
        /// Methode return the last node. Is starting in chain  at the _head and move forward one more at a time until the Next node is null, and is not any node in the chain.
        /// </summary>
        public static Node GetLastNode(this Node _head)
        {
            Node node = _head;
            while (node.Next is not null)
            {
                node = node.Next;
            }
            return node;
        }

        public static void AddFirst(this DoublyLinkedList list, int node)
        {
            Node newNode = new Node(node);
            if(list is not null)
            {
                newNode.Next = list.Head;
                list.Head.Previous = newNode;
            }
            list.Head = newNode;
        }

        public static void AddLast(this DoublyLinkedList list, int t)
        {
            Node newNode = new Node(t);
            if(list is null)
            {
                list.Head = newNode;
                return;
            }
            Node lastNode = list.Head.GetLastNode();
            lastNode.Next = newNode;
            newNode.Previous = lastNode;
        }

    }
}
