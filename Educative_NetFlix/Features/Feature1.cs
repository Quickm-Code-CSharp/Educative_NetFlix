using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educative_NetFlix.Features
{
    public class Feature1
    {
        public static List<List<string>> GroupTitles(string[] strs)
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

    }
}
