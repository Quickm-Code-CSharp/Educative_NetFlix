using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educative_NetFlix.Support.LinkedList
{
    class NetflixDoubleLinkedListNode
    {
        public int key;
        public int val;
        public int freq;
        public NetflixDoubleLinkedListNode next;
        public NetflixDoubleLinkedListNode prev;


        public NetflixDoubleLinkedListNode(int key, int val, int freq)
        {
            this.key = key;
            this.val = val;
            this.freq = freq;
            this.next = null;
            this.prev = null;
        }

    }
}
