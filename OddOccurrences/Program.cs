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

#if DEBUG
            Console.SetIn(new System.IO.StreamReader(@"D:\input.txt"));
#endif

            var input = Console.ReadLine();
            var myDict = new Dictionary<string, int>();

            var words = input.Split(' ').ToList();

            while (words.Count > 0)
            {
                int count = 0;
                string singleWord = words[0].ToLower();

                for (int i = 0; i < words.Count; i++)
                {
                    if (words[i].ToLower() == singleWord)
                    {
                        count++;
                        words.RemoveAt(i);
                        i--;
                    }
                }
                myDict.Add(singleWord, count);
            }

            var myList = new List<string>();

            foreach (KeyValuePair<string, int> item in myDict)
            {
                if (item.Value % 2 != 0)
                {
                    myList.Add(item.Key);

                }
            }

            Console.WriteLine(String.Join(", ", myList));
        }
    }
}
