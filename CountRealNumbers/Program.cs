using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

#if DEBUG
            Console.SetIn(new System.IO.StreamReader(@"E:\input.txt"));
#endif


            var myList = Console.ReadLine().Split().Select(double.Parse).ToArray();

            var myDict = new SortedDictionary<double, int>();

            foreach (var item in myList)
            {
                if (myDict.ContainsKey(item)) myDict[item]++;
                else myDict[item] = 1;
            }

            foreach (var item in myDict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
