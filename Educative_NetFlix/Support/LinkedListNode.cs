using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educative_NetFlix
{
    public class LinkedListNode
    {
        public int key;
        public int data;
        public LinkedListNode next;
        public LinkedListNode arbitraryPointer;

        public LinkedListNode(int data)
        {
            this.data = data;
            this.next = null;
        }

        public LinkedListNode(int key, int data)
        {
            this.key = key;
            this.data = data;
            this.next = null;
        }

        public LinkedListNode(int data, LinkedListNode next)
        {
            this.data = data;
            this.next = next;
        }

        public LinkedListNode(int data, LinkedListNode next, LinkedListNode arbitraryPointer)
        {
            this.data = data;
            this.next = next;
            this.arbitraryPointer = arbitraryPointer;
        }
    }
}
