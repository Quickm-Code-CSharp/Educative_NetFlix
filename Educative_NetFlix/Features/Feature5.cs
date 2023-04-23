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
        Dictionary<int, DoubleLinkedListNode> cache;
        DoubleLinkedList cacheVals;

        public Feature5(int capacity)
        {
            this.capacity = capacity;
            cache = new Dictionary<int, DoubleLinkedListNode>(capacity);
            cacheVals = new DoubleLinkedList();
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
                cacheVals.removeNode(cache[key]);
                cacheVals.insertAtTail(key, value);
                return cacheVals.getTail();
            }
        }

        public void Set(int key, int value)
        {
            if (!cache.ContainsKey(key))
            {
                EvictIfNeeded();
                cacheVals.insertAtTail(key, value);
                cache[key] = cacheVals.getTail();
            }
            else
            {
                cacheVals.removeNode(cache[key]);
                cacheVals.insertAtTail(key, value);
                cache[key] = cacheVals.getTail();
            }
        }

        private void EvictIfNeeded()
        {
            if (cacheVals.size >= capacity)
            {
                DoubleLinkedListNode node = cacheVals.removeHead();
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
