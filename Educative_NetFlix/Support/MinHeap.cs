using System;
using System.Collections.Generic;

class MinHeap<T> where T : IComparable<T>
{
    List<T> h = null;

    public MinHeap()
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

    void MinHeapify(int i)
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
    public void Insert(T key)
    {
        // Push elements into vector from the back
        h.Add(key);
        // Store index of last value of vector in  variable i
        int i = Size() - 1;
        // Restore heap property
        PercolateUp(i);
    }

    //percolateUp(): It is meant to restore the 
    //heap property going up from a node to the root.
    void PercolateUp(int i)
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
            MinHeapify(0);
        }

    }
    public void BuildHeap(T[] arr, int size)
    {
        // Copy elements of array into the List h 
        h.AddRange(arr);
        for (int i = (size - 1) / 2; i >= 0; i--)
        {
            MinHeapify(i);
        }
    }

    //Bonus function: printHeap()
    public void PrintHeap()
    {
        for (int i = 0; i <= Size() - 1; i++)
        {
            Console.Write(h[i] + " ");
        }
        Console.WriteLine("");

    }
}