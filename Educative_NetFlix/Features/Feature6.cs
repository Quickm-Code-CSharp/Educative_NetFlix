using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Educative_NetFlix.Support;
using Educative_NetFlix.Support.LinkedList;

namespace Educative_NetFlix.Features
{
    class Feature6
    {
        int capacity;
        int size;
        int minFreq;
        //LinkedListNode holds key and value pairs
        Dictionary<int, DoubleLinkedListFreqNode> keyDict;
        Dictionary<int, DoubleLinkedFreqList> freqDict;

        public Feature6(int capacity)
        {
            this.capacity = capacity;
            this.size = 0;
            this.minFreq = 0;
            keyDict = new Dictionary<int, DoubleLinkedListFreqNode>(capacity);
            freqDict = new Dictionary<int, DoubleLinkedFreqList>(capacity);
        }

        public DoubleLinkedListFreqNode Get(int key)
        {
            if (!keyDict.ContainsKey(key))
            { 
                return null;
            }
            DoubleLinkedListFreqNode temp = this.keyDict[key];
            this.freqDict[temp.freq].DeleteNode(temp);
            if (this.freqDict[this.keyDict[key].freq] == null)
            {
                this.freqDict.Remove(this.keyDict[key].freq);
                if (this.minFreq == this.keyDict[key].freq)
                {
                    this.minFreq += 1;
                }
            }
            this.keyDict[key].freq += 1;
            if (!this.freqDict.ContainsKey(this.keyDict[key].freq))
            {
                this.freqDict[this.keyDict[key].freq] = new DoubleLinkedFreqList();
            }

            this.freqDict[this.keyDict[key].freq].AppendNode(this.keyDict[key]);
            return this.keyDict[key];
        }

        public void Set(int key, int value)
        {
            if (this.Get(key) != null)
            {
                this.keyDict[key].data = value;
                return;
            }
            if (this.size == this.capacity)
            {
                this.keyDict.Remove(this.freqDict[this.minFreq].head.key);
                this.freqDict[this.minFreq].DeleteNode(this.freqDict[this.minFreq].head);
                if (this.freqDict[this.minFreq] == null)
                {
                    this.freqDict.Remove(this.minFreq);
                }
                this.size -= 1;
            }
            this.minFreq = 1;
            this.keyDict[key] = new DoubleLinkedListFreqNode(key, value, this.minFreq);
            if (!this.freqDict.ContainsKey(this.keyDict[key].freq))
            {
                this.freqDict[this.keyDict[key].freq] = new DoubleLinkedFreqList();
            }
            this.freqDict[this.keyDict[key].freq].AppendNode(this.keyDict[key]);
            this.size++;
        }

        public void Print()
        {
            foreach (var entry in keyDict)
            {
                Console.Write("(" + entry.Key + ", " + entry.Value.data + ")");
            }
            Console.WriteLine("");
        }
    }
}
