using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDoubleLinkedList.Models
{
    internal class DoublyLinkedList<T>
    {
        // this Node class is created in DoublyLinkedList for easy reference
        internal class Node
        {
            internal T Value { get; set; }
            internal Node Previous { get; set; }
            internal Node Next { get; set; }

            public Node(T t)
            {
                Value = t;
                Previous = null;
                Next = null;
            }
        }

        private Node _head;

        public Node First => _head;

        public Node Last
        {
            get
            {
                Node node = GetLastNode();
                return node;
            }

        }

        public Node Next => _head.Next;
        public Node Previous => _head.Previous;

        /// <summary>
        /// Methode return the last node. Is starting in chain at the _head and move forward one more at a time until the Next node is null, and is not any node in the chain.
        /// </summary>
        private Node GetLastNode()
        {
            Node node = _head;
            while (node.Next is not null)
            {
                node = node.Next;
            }
            return node;
        }
    }
}
