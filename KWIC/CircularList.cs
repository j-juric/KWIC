using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KWIC
{
    class CircuralList
    {
        private Node head;
        private Node tail;
        private int count;

        public int Count { get => count; set => count = value; }
        internal Node Head { get => head; set => head = value; }
        internal Node Tail { get => tail; set => tail = value; }

        public CircuralList()
        {
            this.Head = null;
            this.Tail = null;
            this.count = 0;
        }

        public void AddToTail(Node n)
        {
            if (count == 0)
            {
                n.Next = n;
                this.Head = n;
                this.Tail = n;
            }
            else
            {
                n.Next = this.Head;
                this.Tail.Next = n;
                this.Tail = n;
            }
            this.count++;
        }

        public Node GetNext(Node n)
        {
            if (n.Next != null)
                return n.Next;
            return null;
        }

        public void Shift()
        {
            this.Head = this.Head.Next;
            this.Tail = this.Tail.Next;
        }
    }
}
