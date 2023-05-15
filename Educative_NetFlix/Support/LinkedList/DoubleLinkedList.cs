using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educative_NetFlix.Support
{
    class DoubleLinkedList<TNode> where TNode : IDoubleLinkedListNode
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

        public void InsertAtHead(int key, int data)
        {
            DoubleLinkedListNode newNode = new DoubleLinkedListNode(key, data);
            if (this.head == null)
            {
                this.tail = newNode;
            }
            else
            {
                newNode.next = this.head;
                this.head.prev = newNode;
            }
            this.head = newNode;
            this.size++;
        }

        public void InsertAtHead(TNode node)
        {
            var detailNode = node as DoubleLinkedListNode;
            InsertAtHead(detailNode.key, detailNode.data);
        }


        public void InsertAtTail(int key, int data)
        {
            DoubleLinkedListNode newNode = new DoubleLinkedListNode(key, data);
            if (this.tail == null)
            {
                this.head = newNode;
                newNode.prev = null;
                newNode.next = null;
            }

            else
            {
                this.tail.next = newNode;
                newNode.prev = this.tail;
                newNode.next = null;
            }

            this.tail = newNode;
            this.size++;
        }

        public void InsertAtTail(TNode node)
        {
            var detailNode = node as DoubleLinkedListNode;
            InsertAtTail(detailNode.key, detailNode.data);
        }

        public DoubleLinkedListNode Head => this.head;

        public DoubleLinkedListNode Tail => this.tail;

        public DoubleLinkedListNode RemoveNode(DoubleLinkedListNode node)
        {
            if (node != null)
            {
                if (node.prev != null)
                {
                    node.prev.next = node.next;
                }
                else
                {
                    this.head = node.next;
                }


                if (node.next != null)
                {
                    node.next.prev = node.prev;
                }
                else
                {
                    this.tail = node.prev;
                }

                node.next = null;
                node.prev = null;

                this.size--;
                //return node;
            }
            return node;
        }

        public void Remove(int data)
        {
            DoubleLinkedListNode i = this.Head;
            while (i != null)
            {
                if (i.data == data)
                {
                    this.RemoveNode(i);
                }
                i = i.next;
            }
        }

        public DoubleLinkedListNode RemoveHead() => this.RemoveNode(this.head);

        public DoubleLinkedListNode RemoveTail() => this.RemoveNode(this.tail);

    }
}
