using System;
using System.Collections.Generic;
using System.Linq;

namespace TakeManyValueOfList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("cat");
            list.Add("dog");
            list.Add("programmer");
            list.Add("programmer2");
            list.Add("programmer3");

            // Get first 2 elements
            var first = list.Take(2);
            Console.WriteLine("Take 2 element: ");
            foreach (string s in first)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            // Get last 2 elements reversed
            Console.WriteLine("Take 2 element reversed: ");
            var last = list.Reverse<string>().Take(2);
 
            foreach (string s in last)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            // Get last 2 elements
            Console.WriteLine("Take last 2 element: ");
            var last2 = list.Skip(Math.Max(0, list.Count() - 2)).Take(2);

            foreach (string s in last2)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
}
