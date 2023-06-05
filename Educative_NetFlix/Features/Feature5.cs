using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Educative_NetFlix.Support;

namespace Educative_NetFlix.Features
{
    class Feature5
    {
        int capacity;
        Dictionary<int, DoubleLinkedListNode>  cache;
        DoubleLinkedList<DoubleLinkedListNode> cacheVals;

        public Feature5(int capacity)
        {
            this.capacity = capacity;
            cache         = new Dictionary<int, DoubleLinkedListNode>(capacity);
            cacheVals     = new DoubleLinkedList<DoubleLinkedListNode>();
        }

        public DoubleLinkedListNode Get(int key)
        {
            if (!cache.ContainsKey(key))
            {
                return null;
            }
            else
            {
                int value = cache[key].data;
                cacheVals.RemoveNode(cache[key]);

                var node = new DoubleLinkedListNode(key, value);
                cacheVals.AppendNode(node);
                //cacheVals.Append(key, value);
                return cacheVals.Tail;
            }
        }

        public void Set(int key, int value)
        {
            if (cache.ContainsKey(key))
            {
                cacheVals.RemoveNode(cache[key]);
            }
            else
            {
                EvictIfNeeded();
            }

            var node = new DoubleLinkedListNode(key, value); 
            cacheVals.AppendNode(node);
            cache[key] = cacheVals.Tail;

        }

        private void EvictIfNeeded()
        {
            if (cacheVals.size >= capacity)
            {
                DoubleLinkedListNode node = cacheVals.RemoveHead();
                cache.Remove(node.key);
            }
        }

        public void Print()
        {
            var node = cacheVals.head;
            while (node != null)
            {
                System.Console.Write("(" + node.key + "," + node.data + ")");
                node = node.next;
            }
            System.Console.WriteLine("");
        }

    }
}
