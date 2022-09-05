using System.Collections;

namespace CustomDoubleLinkedList.Models
{
    public class DoubleLinkedList : IEnumerable<Node>
    {
        public Node Head;

        public Node First => Head;

        public Node Last
        {
            get
            {
                Node node = GetLastNode();
                return node;
            }
            set { }
        }

        public Node Next => Head.Next;
        public Node Previous => Head.Previous;

        private int _count;
        public int Length => _count;

        public IEnumerator<Node> GetEnumerator()
        {
            Node current = Head;
            while (current is not null)
            {
                yield return current;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerable<Node> GetEnumeratorReverse()
        {
            Node current = Last;
            while (current is not null)
            {
                yield return current;
                current = current.Previous;

            }
        }

        public void Add(int data)
        {
            Node newNode = new Node(data);
            if (Head is null)
            {
                Head = newNode;
            }
            else
            {
                Node current = Last;
                current.Next = newNode;
                newNode.Previous = current;
            }

            _count++;
        }

        /// <summary>
        /// Methode return the last node. Is starting in chain  at the _head and move forward one more at a time until the Next node is null, and is not any node in the chain.
        /// </summary>
        public Node GetLastNode()
        {
            Node node = Head;
            while (node.Next is not null)
            {
                node = node.Next;
            }
            return node;
        }

        public void AddFirst(int node)
        {
            Node newNode = new Node(node);
            if (Head is not null)
            {
                newNode.Next = Head;
                Head.Previous = newNode;
                _count++;
            }
            Head = newNode;
        }

        public void AddLast(int t)
        {
            Node newNode = new Node(t);
            if (Head is null)
            {
                Head = newNode;
                return;
            }
            Node lastNode = Last;
            lastNode.Next = newNode;
            newNode.Previous = lastNode;
            _count++;
        }

        public void RemoveAt(int position)
        {
            _count--;
            if (position == 1 && Head != null)
            {
                Node nodeToDelete = Head;
                Head = Head.Next;
                nodeToDelete = null;
                if (Head != null)
                    Head.Previous = null;
            }
            else
            {
                Node temp = new Node();
                temp = Head;
                for (int i = 1; i < position - 1; i++)
                {
                    if (temp != null)
                    {
                        temp = temp.Next;
                    }
                }
                if (temp != null)
                {
                    Node nodeToDelete = temp.Next;
                    temp.Next = temp.Next.Next;
                    if (temp.Next?.Next != null)
                    {
                        temp.Next.Previous = temp.Next;
                    }
                    else
                    {
                        Last = temp;
                    }
                    nodeToDelete = null;
                }
                else
                {
                    Console.Write("\nThe node is already null.");
                }
            }

        }
    }
}
