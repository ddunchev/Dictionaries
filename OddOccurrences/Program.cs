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


            Dictionary<string, int> myListOfPeoples = new Dictionary<string, int>();
            var input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                Console.WriteLine("Enter your name and age");
                myListOfPeoples.Add(Console.ReadLine(), int.Parse(Console.ReadLine()));
            }

            foreach (var item in myListOfPeoples)
            {
                Console.WriteLine(item.Key);
            }

            foreach ( item in myListOfPeoples)
            {
                Console.WriteLine(item.Key);
            }

            if (myListOfPeoples.TryGetValue("Dancho", out int test))
            {
                Console.WriteLine($"The age of {myListOfPeoples.ElementAt(0)} are {test}");
            }
        }
    }
}
