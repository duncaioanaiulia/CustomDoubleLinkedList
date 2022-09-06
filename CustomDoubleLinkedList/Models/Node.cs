using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDoubleLinkedList.Models
{
    public class Node
    {
        public int Value { get; set; }
        public Node Previous { get; set; }
        public Node Next { get; set; }

        public Node() { }

        public Node(int t)
        {
            Value = t;
            Previous = null;
            Next = null;
        }
    }
}
