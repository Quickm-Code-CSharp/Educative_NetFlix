using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educative_NetFlix
{
    class Features
    {
        public static List<List<string>> Feature1(string[] strs) => GroupTitles(strs);
        public static LinkedListNode     Feature2(List<LinkedListNode> lists) => MergeKSortedLists(lists);

        protected static List<List<string>> GroupTitles(string[] strs)
        {
            if (strs.Length == 0)
            {
                return new List<List<string>>();
            }

            Dictionary<string, List<string>> res = new Dictionary<string, List<string>>();

            foreach (string s in strs)
            {
                // get count of each letter
                int[] count = new int[26];
                foreach (var c in s.ToCharArray())
                {
                    int index = c - 'a';
                    count[index]++;
                }

                // assemble string for key
                StringBuilder delimStr = new StringBuilder("");
                for (int i = 0; i < 26; i++)
                {
                    delimStr.Append('#');
                    delimStr.Append(count[i]);
                }

                // store in dictionary
                string key = delimStr.ToString();
                if (!res.ContainsKey(key))
                {
                    res[key] = new List<string>();
                }

                Console.WriteLine($"Dictionary entry: key: {key} value: {s}");

                res[key].Add(s);
            }

            return new List<List<string>>(res.Values.ToList());
        }

        protected static LinkedListNode MergeKSortedLists(List<LinkedListNode> lists)
        {

            if (lists.Count > 0)
            {
                LinkedListNode res = lists[0];

                for (int i = 1; i < lists.Count; i++)
                    res = Merge2SortedLists(res, lists[i]);

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

            if (list1 == null)
                prev.next = list2;
            else
                prev.next = list1;

            return dummy.next;
        }

    }
}
