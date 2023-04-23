using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educative_NetFlix.Support
{
    class DoubleLinkedList
    {
        public DoubleLinkedListNode head;
        public DoubleLinkedListNode tail;
        public int size;

        public DoubleLinkedList()
        {
            this.head = null;
            this.tail = null;
            this.size = 0;
        }

        public void insertAtHead(int key, int data)
        {
            DoubleLinkedListNode newNode = new DoubleLinkedListNode(key, data);
            if (this.head == null)
            {
                this.head = newNode;
                this.tail = newNode;
            }
            else
            {
                newNode.next = this.head;
                this.head.prev = newNode;
                this.head = newNode;
            }
            this.size++;
        }

        public void insertAtTail(int key, int data)
        {
            DoubleLinkedListNode newNode = new DoubleLinkedListNode(key, data);
            if (this.tail == null)
            {
                this.tail = newNode;
                this.head = newNode;
                newNode.next = null;
                newNode.prev = null;
            }

            else
            {
                this.tail.next = newNode;
                newNode.prev = this.tail;
                this.tail = newNode;
                newNode.next = null;
            }
            this.size++;
        }

        public DoubleLinkedListNode getHead()
        {
            return this.head;
        }

        public DoubleLinkedListNode getTail()
        {
            return this.tail;
        }

        public DoubleLinkedListNode removeNode(DoubleLinkedListNode node)
        {
            if (node == null)
            {
                return null;
            }

            if (node.prev != null)
            {
                node.prev.next = node.next;
            }

            if (node.next != null)
            {
                node.next.prev = node.prev;
            }

            if (node == this.head)
            {
                this.head = this.head.next;
            }
            if (node == this.tail)
            {
                this.tail = this.tail.prev;
            }
            this.size--;
            return node;
        }

        public void remove(int data)
        {
            DoubleLinkedListNode i = this.getHead();
            while (i != null)
            {
                if (i.data == data)
                {
                    this.removeNode(i);
                }
                i = i.next;
            }
        }

        public DoubleLinkedListNode removeHead()
        {
            return this.removeNode(this.head);
        }

        public DoubleLinkedListNode removeTail()
        {
            return this.removeNode(this.tail);
        }

    }
}
