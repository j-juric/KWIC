using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KWIC
{
    class Node
    {

        private String value;
        private Node next;

        public string Value { get => value; set => this.value = value; }
        internal Node Next { get => next; set => next = value; }

        public Node() { }
        public Node(String v)
        {
            this.Value = v;
            this.Next = null;
        }
    }
}
