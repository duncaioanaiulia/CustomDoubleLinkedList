using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDoubleLinkedList.Models
{
    internal class Node
    {
        internal int Value { get; set; }
        internal Node Previous { get; set; }
        internal Node Next { get; set; }

        public Node(int t)
        {
            Value = t;
            Previous = null;
            Next = null;
        }
    }
}
