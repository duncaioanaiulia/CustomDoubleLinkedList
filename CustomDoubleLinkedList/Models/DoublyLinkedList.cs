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

        private DoublyLinkedList<T>.Node GetLastNode()
        {
            throw new NotImplementedException();
        }
    }
}
