using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educative_NetFlix.Features
{
    class Feature7
    {
        private Stack<int> mainStack;
        private Stack<int> maxStack;

        public Feature7()
        {
            mainStack = new Stack<int>();
            maxStack = new Stack<int>();
        }

        public void Push(int rating)
        {
            //1. Push value in mainStack and check value with the top value of maxStack
            //2. If value is greater than top, then push top in maxStack
            //else push value in maxStack
            mainStack.Push(rating);

            int valueToPush = rating;

            if (maxStack.Count != 0)
            {
                int currentMax = maxStack.Peek();
                if (currentMax >= rating)
                {
                    valueToPush = currentMax;
                }
            }

            maxStack.Push(valueToPush);
        }

        public int Pop()
        {
            int rating;

            _ = maxStack.Pop();
            rating = mainStack.Pop();

            return rating;
        }

        public int MaxRating()
        {
            return maxStack.Peek();
        }
    }
}
