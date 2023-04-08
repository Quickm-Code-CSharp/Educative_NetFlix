using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educative_NetFlix.Support
{
    abstract class HeapBase<T>
    {
        protected delegate void HeapDelegate(int i);
        protected HeapDelegate heapDelegate = null;
        protected List<T> h = null;

        public HeapBase()
        {
            h = new List<T>();
        }

        public int Parent(int i)
        {
            return (i - 1) / 2;
        }
        public int Lchild(int i)
        {
            return i * 2 + 1;
        }
        public int Rchild(int i)
        {
            return i * 2 + 2;
        }
        public int Size()
        {
            return h.Count;
        }

        public T Peek()
        {
            if (Size() <= 0)
            {
                return (T)Convert.ChangeType(-1, typeof(T));
            }
            else
            {
                return h[0];
            }
        }

        public void Insert(T key)
        {
            // Push elements into vector from the back
            h.Add(key);
            // Store index of last value of vector in  variable i
            int i = Size() - 1;
            // Restore heap property
            PercolateUp(i);
        }

        abstract protected void PercolateUp(int i);

        public void Poll()
        {
            if (Size() == 1)
            {
                // Remove the last item from the list
                h.RemoveAt(h.Count - 1);
            }
            else if (Size() > 1)
            {
                // Swaps the value of two variables
                T temp = h[0];
                h[0] = h[Size() - 1];
                h[Size() - 1] = temp;
                // Deletes the last element
                h.RemoveAt(h.Count - 1);
                // Restore heap property
                //MaxHeapify(0);
                heapDelegate(0);
            }
        }
        public void BuildHeap(T[] arr, int size)
        {
            // Copy elements of array into the List h 
            h.AddRange(arr);
            for (int i = (size - 1) / 2; i >= 0; i--)
            {
                heapDelegate(i);
            }
        }
        public void PrintHeap()
        {
            for (int i = 0; i <= Size() - 1; i++)
            {
                Console.Write(h[i] + " ");
            }
            Console.WriteLine("");
        }


    }
}
