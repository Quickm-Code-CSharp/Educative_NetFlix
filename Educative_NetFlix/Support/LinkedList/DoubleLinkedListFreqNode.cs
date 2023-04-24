using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educative_NetFlix.Support
{
    class DoubleLinkedListFreqNode : DoubleLinkedListNode
    {
        public int freq;

        public DoubleLinkedListFreqNode(int data) : base(data)
        {
        }

        public DoubleLinkedListFreqNode(int key, int data) : base(key, data)
        {
        }

        public DoubleLinkedListFreqNode(int key, int data, int freq) : base(key, data)
        {
            this.freq = freq;
        }

        public DoubleLinkedListFreqNode(int data, DoubleLinkedListNode next) : base(data, next)
        {
        }

        public DoubleLinkedListFreqNode(int data, DoubleLinkedListNode next, DoubleLinkedListNode prev) : base(data, next, prev)
        {
        }
    }
}
