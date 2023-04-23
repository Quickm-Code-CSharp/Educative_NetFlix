using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educative_NetFlix.Support
{
    class DoubleLinkedListFreq : DoubleLinkedListNode
    {
        int freq;

        public DoubleLinkedListFreq(int data) : base(data)
        {
        }

        public DoubleLinkedListFreq(int key, int data) : base(key, data)
        {
        }

        public DoubleLinkedListFreq(int key, int data, int freq) : base(key, data)
        {
            this.freq = freq;
        }

        public DoubleLinkedListFreq(int data, DoubleLinkedListNode next) : base(data, next)
        {
        }

        public DoubleLinkedListFreq(int data, DoubleLinkedListNode next, DoubleLinkedListNode prev) : base(data, next, prev)
        {
        }
    }
}
