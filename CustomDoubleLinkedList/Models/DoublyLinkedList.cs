using CustomDoubleLinkedList.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDoubleLinkedList.Models
{
    public class DoublyLinkedList
    {
        private Node _head;

        public Node First => _head;

        public Node Last
        {
            get
            {
                Node node = _head.GetLastNode();
                return node;
            }

        }

        public Node Next => _head.Next;
        public Node Previous => _head.Previous;

    }
}
