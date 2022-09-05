using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomDoubleLinkedList.Models;

namespace CustomDoubleLinkedList.Extensions
{
    public static class Methods
    {

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

        public static void AddFirst(this Node _head, int node)
        {
            Node newNode = new Node(node);
            if(_head is not null)
            {
                newNode.Next = _head;
                _head.Previous = newNode;
            }
            _head = newNode;
        }

        public static void AddLast(this Node _head, int t)
        {
            Node newNode = new Node(t);
            if(_head is null)
            {
                _head = newNode;
                return;
            }
            Node lastNode = _head.GetLastNode();
            lastNode.Next = newNode;
            newNode.Previous = lastNode;
        }

    }
}
