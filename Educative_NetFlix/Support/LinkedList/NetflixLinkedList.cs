using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educative_NetFlix.Support.LinkedList
{
    class NetflixDoubleLinkedList
    {
        // using DoubleLinkedListFreq class
        public DoubleLinkedListFreqNode head;
        public DoubleLinkedListFreqNode tail;
        public NetflixDoubleLinkedList()
        {
            this.head = null;
            this.tail = null;
        }

        public void AppendNode(DoubleLinkedListFreqNode node)
        {
            node.next = null;
            node.prev = null;
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                this.tail.next = node;
                node.prev = this.tail;
            }
            this.tail = node;
        }

        public void DeleteNode(DoubleLinkedListFreqNode node)
        {
            if (node.prev != null)
            {
                node.prev.next = node.next;
            }
            else
            {
                this.head = (DoubleLinkedListFreqNode)node.next;
            }
            if (node.next != null)
            {
                node.next.prev = node.prev;
            }
            else
            {
                this.tail = (DoubleLinkedListFreqNode)node.prev;
            }
            node.next = null;
            node.prev = null;
        }
    }
}
