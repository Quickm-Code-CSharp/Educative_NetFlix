using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educative_NetFlix.Features
{
    class Feature4
    {
        public static bool IdentifyTitles(int[] scores)
        {
            bool valid = true;

            bool increasing = true;
            bool decreasing = true;

            for (int i = 0; i < scores.Length - 1; i++)
            {
                if (scores[i] > scores[i + 1])
                    increasing = false;
                if (scores[i] < scores[i + 1])
                    decreasing = false;
            }

            valid = increasing || decreasing;

            return valid;
        }
    }
}
