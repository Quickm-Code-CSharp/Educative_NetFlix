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
            feature.insertNum(age);
            var median = feature.findMedian();

            return median;
        }

        public static bool Feature4(int[] ratings) => Features.Feature4.IdentifyTitles(ratings);
    }
}
