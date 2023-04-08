using System;
using System.Collections.Generic;
using Educative_NetFlix.Support;

class MinHeap<T> : HeapBase<T> where T : IComparable<T>
{
    public MinHeap()
    {
        heapDelegate = MinHeapify;
    }

    public void MinHeapify(int i)
    {
        int lc = Lchild(i);
        int rc = Rchild(i);
        int imin = i;
        if (lc < Size() && (h[lc].CompareTo(h[imin]) < 0))
        {
            imin = lc;
        }
        if (rc < Size() && (h[rc].CompareTo(h[imin]) < 0))
        {
            imin = rc;
        }
        if (i != imin)
        {
            T temp = h[i];
            h[i] = h[imin];
            h[imin] = temp;
            MinHeapify(imin);
        }
    }

    //percolateUp(): It is meant to restore the 
    //heap property going up from a node to the root.
    override protected void PercolateUp(int i)
    {
        if (i <= 0)
        {
            return;
        }
        else if (h[Parent(i)].CompareTo(h[i]) > 0)
        {
            // Swaps the value of two variables
            T temp = h[i];
            h[i] = h[Parent(i)];
            h[Parent(i)] = temp;
            PercolateUp(Parent(i));
        }
    }
}