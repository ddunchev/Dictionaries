using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            var myString = new string[]{
                "banana",
                "appricot",
                "peach"
            };

            var myDict = myString.ToDictionary(item => item, item => 0);

            foreach (var item in myDict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }


        }
    }
}
