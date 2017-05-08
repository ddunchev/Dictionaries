using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, int>()
            {
                {"apple", 1},
                {"appricot", 2},
                {"banana", 5}
            };


            var list = new List<string>(dict.Keys);

            var s1 = Stopwatch.StartNew();
            foreach (var item in list)
            {
                Console.WriteLine($"{item} -> {dict[item]}");
            }

            s1.Stop();

            Console.WriteLine(s1.Elapsed.TotalMilliseconds);
        }
    }
}
