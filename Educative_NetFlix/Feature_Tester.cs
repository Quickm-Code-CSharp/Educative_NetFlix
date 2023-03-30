using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            List<List<string>> gt = Features.Feature1(titles);

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

            List<LinkedListNode> list1 = new List<LinkedListNode>();
            list1.Add(a);
            list1.Add(b);
            list1.Add(c);

            Console.WriteLine("All movie ID's from best to worse are:");
            LinkedList.Display(Features.Feature2(list1));

        }
        public void Feature_03_Tester()
        {
            Console.WriteLine("Feature 03");
            Console.WriteLine("Not Implemented yet");
        }
        public void Feature_04_Tester()
        {
            Console.WriteLine("Feature 04");
            Console.WriteLine("Not Implemented yet");
        }
        public void Feature_05_Tester()
        {
            Console.WriteLine("Feature 05");
            Console.WriteLine("Not Implemented yet");
        }
        public void Feature_06_Tester()
        {
            Console.WriteLine("Feature 06");
            Console.WriteLine("Not Implemented yet");
        }
        public void Feature_07_Tester()
        {
            Console.WriteLine("Feature 07");
            Console.WriteLine("Not Implemented yet");
        }
        public void Feature_08_Tester()
        {
            Console.WriteLine("Feature 08");
            Console.WriteLine("Not Implemented yet");
        }
        public void Feature_09_Tester()
        {
            Console.WriteLine("Feature 09");
            Console.WriteLine("Not Implemented yet");
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
            string result = string.Empty;
            StringBuilder sb = new StringBuilder();

            foreach (var item in strs)
            {
                sb.Append(item + " ");
            }

            result = sb.ToString();

            return result;
        }
    }
}
