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

        public static void Feature6(Feature6 feature, KeyValuePair<int, int> kvp)
        {
            if (kvp.Value != 0)
            {
                feature.Set(kvp.Key, kvp.Value);
            }

            else
            {
                feature.Get(kvp.Key);
            }

            if ((kvp.Key == 2 && kvp.Value == 2) ||
                (kvp.Key == 3 && kvp.Value == 3) ||
                (kvp.Key == 4 && kvp.Value == 0))
            {
                feature.Print();
            }
        }

        public static void Feature7(Feature7 feature, int rating)
        {
            feature.Push(rating);
        }

        public static void Feature8(Feature8 feature, int[] pushData, int[] popData)
        {
            bool valid = feature.VerifyStacks(pushData, popData);

            ReportVerification(valid);
        }

        public static void Feature9(Feature9 feature, string[] categories,string runTitle)
        {
            List<string> combinations = feature.LetterCombinations(categories);

            feature.PrintOutput(categories, combinations, runTitle);
        }

        private static void ReportVerification(bool verifyResult)
        {
            string msg = (verifyResult) ? "Session Successfull!" : "Session Faulty!";
            Console.WriteLine(msg);

        }
    }
}
