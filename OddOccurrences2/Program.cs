using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurrences2
{
    class Program
    {
        static void Main(string[] args)
        {

#if DEBUG
            Console.SetIn(new System.IO.StreamReader(@"E:\input.txt"));
#endif

            var input = Console.ReadLine().ToLower().Split();

            var myDict = new Dictionary<string, int>();

            foreach (var word in input)
            {
                if (myDict.ContainsKey(word)) myDict[word]++;
                else myDict[word] = 1;
            }

            var myList = new List<string>();

            foreach (KeyValuePair<string, int> pair in myDict)
            {
                if (pair.Value % 2 != 0) myList.Add(pair.Key);
            }

            Console.WriteLine(String.Join(", ", myList));
        }
    }
}
