using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Educative_NetFlix.Features;

namespace Educative_NetFlix.Features
{
    class FeatureInvoker
    {
        public static List<List<string>> Feature1(string[] strs) => Features.Feature1.GroupTitles(strs);

        public static LinkedListNode     Feature2(List<LinkedListNode> lists) => Features.Feature2.MergeKSortedLists(lists);

        public static double Feature3(Feature3 feature, int age)
        {
            feature.InsertNum(age);
            var median = feature.FindMedian();

            return median;
        }

        public static bool Feature4(int[] ratings) => Features.Feature4.IdentifyTitles(ratings);

        public static void Feature5(Feature5 feature, KeyValuePair<int, int> kvp)
        {
            if (kvp.Value != 0)
            {
                feature.Set(kvp.Key, kvp.Value);
            }

            else
            {
                feature.Get(kvp.Key);
            }

            feature.Print();
        }
    }
}
