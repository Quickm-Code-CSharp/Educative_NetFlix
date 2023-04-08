using System;
using System.Collections.Generic;
using Educative_NetFlix.Support;

class MaxHeap<T> : HeapBase<T> where T : IComparable<T>
{
    public MaxHeap() : base()
    {
        heapDelegate += MaxHeapify;
    }

    public void MaxHeapify(int i)
    {
        int lc = Lchild(i);
        int rc = Rchild(i);
        int imax = i;

        if (lc < Size() && (h[lc].CompareTo(h[imax]) > 0))
        {
            imax = lc;
        }
        if (rc < Size() && (h[rc].CompareTo(h[imax]) > 0))
        {
            imax = rc;
        }
        if (i != imax)
        {
            T temp = h[i];
            h[i] = h[imax];
            h[imax] = temp;
            //MaxHeapify(imax);
            heapDelegate(imax);
        }
    }

    protected override void PercolateUp(int i)
    {
        if (i <= 0)
        {
            return;
        }
        else if (h[Parent(i)].CompareTo(h[i]) < 0)
        {
            // Swaps the value of two variables
            T temp = h[i];
            h[i] = h[Parent(i)];
            h[Parent(i)] = temp;
            PercolateUp(Parent(i));
        }
    }
}