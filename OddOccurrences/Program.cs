using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var myDict = new Dictionary<string, int>();

            myDict.Add("Dunchev", 42);
            myDict.Add("Stanchevska", 38);
            myDict.Add("Ivanova", 9);

            foreach (KeyValuePair<string, int> item in myDict)
            {
                Console.WriteLine($"Name: {item.Key}, Age: {item.Value}");
            }
        }
    }
}
