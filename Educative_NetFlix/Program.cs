using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educative_NetFlix
{
    class Program
    {
        static void Main(string[] args)
        {
            Feature_Tester tester = new Feature_Tester();

            tester.Feature_1_Tester();

            _ = Console.ReadLine();
        }
    }
}
