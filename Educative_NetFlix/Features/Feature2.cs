using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educative_NetFlix.Features
{
    class Feature2
    {
        public static LinkedListNode MergeKSortedLists(List<LinkedListNode> lists)
        {
            if (lists.Count > 0)
            {
                LinkedListNode res = lists[0];

                for (int i = 1; i < lists.Count; i++)
                {
                    res = Merge2SortedLists(res, lists[i]);
                }

                return res;
            }
            return new LinkedListNode(-1);
        }

        protected static LinkedListNode Merge2SortedLists(LinkedListNode list1, LinkedListNode list2)
        {
            LinkedListNode dummy = new LinkedListNode(-1);

            LinkedListNode prev = dummy;
            while (list1 != null && list2 != null)
            {
                if (list1.data <= list2.data)
                {
                    prev.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    prev.next = list2;
                    list2 = list2.next;
                }
                prev = prev.next;
            }

            prev.next = list1 ?? list2;

            return dummy.next;
        }

    }
}
