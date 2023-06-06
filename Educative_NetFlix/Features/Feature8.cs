using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educative_NetFlix.Features
{
    class Feature8
    {
        public bool VerifyStacks(int[] pushData, int[]popData)
        {
            bool success = false;

            PrintArray(pushData, "Push");
            PrintArray(popData, "Pop ");


            if (pushData.Length == popData.Length)
            {
                Stack<int> stack = new Stack<int>();

                int i = 0;
                foreach (int pid in pushData)
                {
                    stack.Push(pid);
                    while (stack.Count != 0 && stack.Peek() == popData[i])
                    {
                        stack.Pop();
                        i++;
                    }
                }

                if (stack.Count == 0)
                {
                    success = true;
                }
            }

            return success;

        }

        private void PrintArray(int[] array, string title)
        {
            Console.Write($"{title} array: ");
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

        }
    }
}
