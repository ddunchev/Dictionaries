using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedDictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var myDict = new SortedDictionary<DateTime, string>();

            myDict[new DateTime(1972, 11, 21)] = "Dancho Dunchev's birthday";
            myDict[new DateTime(1978, 01, 7)] = "Silva Stanchevska's birthday";
            myDict[new DateTime(2008, 03, 5)] = "Monika Ivanova's birthday";

            foreach (var item in myDict)
            {
                Console.WriteLine("{0: dd-MM-yyyy} -> {1}", item.Key, item.Value);
            }
        }
    }
}
