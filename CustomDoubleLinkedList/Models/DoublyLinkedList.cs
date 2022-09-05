using CustomDoubleLinkedList.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDoubleLinkedList.Models
{
    internal class DoublyLinkedList
    {
        private Node _head;

        internal Node First => _head;

        internal Node Last
        {
            get
            {
                Node node = _head.GetLastNode();
                return node;
            }

        }

        internal Node Next => _head.Next;
        internal Node Previous => _head.Previous;

    }
}
