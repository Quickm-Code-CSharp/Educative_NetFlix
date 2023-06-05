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

            tester.Feature_01_Tester();
            Console.WriteLine();

            tester.Feature_02_Tester();
            Console.WriteLine();

            tester.Feature_03_Tester();
            Console.WriteLine();

            tester.Feature_04_Tester();
            Console.WriteLine();

            tester.Feature_05_Tester();
            Console.WriteLine();

            tester.Feature_06_Tester();
            Console.WriteLine();

            tester.Feature_07_Tester();
            Console.WriteLine();

            //tester.Feature_08_Tester();
            //Console.WriteLine();

            //tester.Feature_09_Tester();
            //Console.WriteLine();

            //tester.Feature_10_Tester();
            //Console.WriteLine();

            //tester.Feature_11_Tester();
            //Console.WriteLine();

            //tester.Feature_12_Tester();
            //Console.WriteLine();

            _ = Console.ReadLine();
        }
    }
}
