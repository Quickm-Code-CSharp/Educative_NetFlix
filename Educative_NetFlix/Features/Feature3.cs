using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educative_NetFlix.Features
{
    class Feature3
    {
        private MaxHeap<int> maxHeap; //containing first half of numbers
        private MinHeap<int> minHeap; //containing second half of numbers

        public Feature3()
        {
            maxHeap = new MaxHeap<int>();
            minHeap = new MinHeap<int>();
        }

        public void InsertNum(int num)
        {
            if (maxHeap.Size() == 0 || maxHeap.Peek() >= num)
            {
                maxHeap.Insert(num);
            }

            else
            {
                minHeap.Insert(num);
            }

            // either both the heaps will have equal number of elements or max-heap will have one 
            // more element than the min-heap
            if (maxHeap.Size() > minHeap.Size() + 1)
            {
                minHeap.Insert(maxHeap.Peek());
                maxHeap.Poll();
            }
            else if (maxHeap.Size() < minHeap.Size())
            {
                maxHeap.Insert(minHeap.Peek());
                minHeap.Poll();
            }
        }

        public double FindMedian()
        {
            if (maxHeap.Size() == minHeap.Size())
            {
                // we have even number of elements, take the average of middle two elements
                return maxHeap.Peek() / 2.0 + minHeap.Peek() / 2.0;
            }
            // because max-heap will have one more element than the min-heap
            return maxHeap.Peek();
        }

    }
}
