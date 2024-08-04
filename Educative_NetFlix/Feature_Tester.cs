using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Educative_NetFlix.Features;

namespace Educative_NetFlix
{
    class Feature_Tester
    {
        public void Feature_01_Tester()
        {
            Console.WriteLine("Feature 1");

            string[] titles = { "duel", "dule", "speed", "spede", "deul", "cars" };
            var titlesStr = StringArrayPrinter(titles);
            Console.WriteLine($"Input data: {titlesStr}");
            Console.WriteLine();

            List<List<string>> gt = FeatureInvoker. Feature1(titles);

            //string query = "spede";
            string query = "deul";
            Console.WriteLine();
            Console.WriteLine($"Searching for: {query}");

            // Searching for all titles
            foreach (List<string> g in gt)
            {
                if (g.Contains(query))
                {
                    Console.WriteLine("[{0}]", string.Join(", ", g));
                }
            }
        }
        public void Feature_02_Tester()
        {
            Console.WriteLine("Feature 02");
            LinkedListNode a = LinkedList.CreateLinkedList(new int[] { 11, 23, 41, 51 });
            Console.Write("List A: ");
            LinkedList.Display(a);

            LinkedListNode b = LinkedList.CreateLinkedList(new int[] { 21, 23, 42 });
            Console.Write("List B: ");
            LinkedList.Display(b);

            LinkedListNode c = LinkedList.CreateLinkedList(new int[] { 25, 56, 66, 72 });
            Console.Write("List C: ");
            LinkedList.Display(c);
            Console.WriteLine();

            List<LinkedListNode> list1 = new List<LinkedListNode>
            {
                a,
                b,
                c
            };

            Console.WriteLine("All movie ID's from best to worse are:");
            LinkedList.Display(FeatureInvoker.Feature2(list1));

        }
        public void Feature_03_Tester()
        {
            Console.WriteLine("Feature 03");

            Feature3 medianOfAges = new Feature3();
            IList<int> ages = new List<int>() { 35, 30,25 };

            medianOfAges.InsertNum(22);
            Console.Write($"Data: 22 ");
            ages.ToList().ForEach(a => Console.Write($"{a} "));
            Console.WriteLine();

            foreach (var age in ages)
            {
                var median = FeatureInvoker.Feature3(medianOfAges, age);
                Console.WriteLine("The recommended content will be for ages under: " + median);
            }
        }
        public void Feature_04_Tester()
        {
            Console.WriteLine("Feature 04");
            int[][] movieRatings = new int[][]
            {
                new int[]{1,2,2,3},
                new int[]{4,5,6,3,4},
                new int[]{8,8,7,6,5,4,4,1}
            };

            foreach (var movieRating in movieRatings)
            {
                System.Console.Write("Movie rating data: ");

                movieRating.ToList().ForEach(rating => Console.Write($"{rating} "));
                bool valid = FeatureInvoker.Feature4(movieRating);

                string msg = (valid) ? "Title Identified and Separated" : "Title Score Fluctuating";
                System.Console.WriteLine(msg);
            }
        }

        public void Feature_05_Tester()
        {
            Console.WriteLine("Feature 05");
            int      capacity = 3;
            Feature5 cache    = new Feature5(capacity);

            System.Console.WriteLine("The most recently watched titles are: (key, value)");
            List<KeyValuePair<int, int>> recentlyWatchedList = new List<KeyValuePair<int, int>>
            {
                new KeyValuePair<int, int>(10, 20),
                new KeyValuePair<int, int>(15, 25),
                new KeyValuePair<int, int>(20, 30),
                new KeyValuePair<int, int>(25, 35),
                new KeyValuePair<int, int>(05, 40),
                new KeyValuePair<int, int>(25, 00)
            };

            foreach (var kvp in recentlyWatchedList)
            {
                FeatureInvoker.Feature5(cache, kvp);
            }
        }
        public void Feature_06_Tester()
        {
            Console.WriteLine("Feature 06");

            int capacity = 2;
            Feature6 cache = new Feature6(capacity);
            Console.WriteLine("The most frequently watched titles are: (key, value)");

            List<KeyValuePair<int, int>> recentlyWatchedList = new List<KeyValuePair<int, int>>
            {
                new KeyValuePair<int, int>(1, 1),
                new KeyValuePair<int, int>(2, 2),
                new KeyValuePair<int, int>(1, 0),
                new KeyValuePair<int, int>(3, 3),
                new KeyValuePair<int, int>(2, 0),
                new KeyValuePair<int, int>(4, 4),
                new KeyValuePair<int, int>(1, 0),
                new KeyValuePair<int, int>(3, 0),
                new KeyValuePair<int, int>(4, 0),
            };

            foreach (var kvp in recentlyWatchedList)
            {
                FeatureInvoker.Feature6(cache, kvp);
            }
        }

        public void Feature_07_Tester()
        {
            Console.WriteLine("Feature 07");

            Feature7 feature = new Feature7();

            List<int> ratingsList = new List<int> { 5, 0, 2, 4, 6, 3, 10 };
            foreach (var rating in ratingsList)
            {
                FeatureInvoker.Feature7(feature, rating);
                Console.WriteLine("Maximum Rating: " + feature.MaxRating());
            }

            feature.Pop();

            Console.WriteLine();
            Console.WriteLine("After clicking back button");
            Console.WriteLine("Maximum Rating: " + feature.MaxRating());
        }
        public void Feature_08_Tester()
        {
            Console.WriteLine("Feature 08");

            Feature8 feature = new Feature8();
            
            // Driver code
            // Positive case
            int[] pushOp = { 1, 2, 3, 4, 5 };
            int[] popOp = { 5, 4, 3, 2, 1 };

            FeatureInvoker.Feature8(feature, pushOp, popOp);
            Console.WriteLine();

            // Negative case
            int[] pushOp2 = { 6, 7, 8, 9, 10 };
            int[] popOp2 = { 8, 10, 7, 9 };

            FeatureInvoker.Feature8(feature, pushOp2, popOp2);

        }
        public void Feature_09_Tester()
        {
            Console.WriteLine("Feature 09");

            Dictionary<string, string[]> movies = new Dictionary<string, string[]>
            {
                { "Family", new string[3]{"Frozen","Kung fu Panda", "Ice Age"} },
                { "Action", new string[3]{"Iron Man","Wonder Woman","Avengers"}},
                { "Fantasy", new string[3]{"Jumangi", "Lion King", "Tarzan"}},
                { "Comedy", new string[4]{"Coco", "The Croods", "Vivi","Pets"}},
                { "Horror", new string[4]{"Oculus", "Sinister","Insidious","Annebelle"}},
            };


            Feature9 feature = new Feature9(movies);

            // Example 1
            string[] categories = new string[1] { "Action" };
            FeatureInvoker.Feature9(feature, categories, "Example 1");

            // Example 2
            categories = new string[2] { "Family", "Action" };
            FeatureInvoker.Feature9(feature, categories, "Example 2");

            // Example 3
            categories = new string[2] { "Horror", "Comedy" };
            FeatureInvoker.Feature9(feature, categories, "Example 3");

            // Example 4
            categories = new string[4] { "Horror", "Fantasy", "Comedy", "Family" };
            FeatureInvoker.Feature9(feature, categories, "Example 4");

        }
        public void Feature_10_Tester()
        {
            Console.WriteLine("Feature 10");
            Console.WriteLine("Not Implemented yet");
        }
        public void Feature_11_Tester()
        {
            Console.WriteLine("Feature 11");
            Console.WriteLine("Not Implemented yet");
        }
        public void Feature_12_Tester()
        {
            Console.WriteLine("Feature 12");
            Console.WriteLine("Not Implemented yet");
        }

        protected string StringArrayPrinter(string[] strs)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in strs)
            {
                sb.Append(item + " ");
            }

            string result = sb.ToString();

            return result;
        }
    }
}
