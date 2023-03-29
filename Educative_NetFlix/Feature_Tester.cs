using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educative_NetFlix
{
    class Feature_Tester
    {
        public void Feature_1_Tester()
        {
            Console.WriteLine("Feature 1");
            Console.WriteLine();

            string[] titles = { "duel", "dule", "speed", "spede", "deul", "cars" };

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
    }
}
