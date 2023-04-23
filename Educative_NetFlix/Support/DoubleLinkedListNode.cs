using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educative_NetFlix.Support
{
    class DoubleLinkedListNode
    {
        public int key;
        public int data;
        public DoubleLinkedListNode next;
        public DoubleLinkedListNode prev;

        public DoubleLinkedListNode(int data)
        {
            this.data = data;
            this.next = null;
            this.prev = null;
        }

        public DoubleLinkedListNode(int key, int data)
        {
            this.key = key;
            this.data = data;
            this.next = null;
            this.prev = null;
        }

        public DoubleLinkedListNode(int data, DoubleLinkedListNode next)
        {
            this.data = data;
            this.next = next;
            this.prev = null;
        }

        public DoubleLinkedListNode(int data, DoubleLinkedListNode next, DoubleLinkedListNode prev)
        {
            this.data = data;
            this.next = next;
            this.prev = prev;
        }
    }
}
