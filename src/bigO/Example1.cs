using System;
using System.Collections.Generic;

namespace bigO
{
    internal static class Example1
    {
        internal static void FindingNemo(IEnumerable<string> names)
        {
            /*
            Worst case n steps (where n is the number of items in the enumerable)
            Hence the time complexity of the below solution is O(n)
            */
            foreach (var item in names)
            {
                if(item.ToUpper().Equals("NEMO"))
                {
                    System.Console.WriteLine("Found Nemo");
                }
            }

        }
    }
}