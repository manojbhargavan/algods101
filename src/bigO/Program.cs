using System;
using Humanizer;

namespace bigO
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. O(n) Function
            Example1.FindingNemo(new string[] { "manoj", "nandan",
            "saranya", "jack", "nemo", "karimeen" });
            var startTime = DateTime.Now;
            var nemoArray = "nemo".GetEnumerablePrePopulated(100000);
            Example1.FindingNemo(nemoArray);
            System.Console.WriteLine($"Time taken to run: {(DateTime.Now - startTime).Humanize()}");

            //2. O(n) example again
            var names = new string[] { "manoj", "nandan",
                "saranya", "jack", "giant", "findme" };
            var itemsToFind = "findme";
            var stepsTaken = 0;
            for (int i = 0; i < names.Length; i++)
            {
                stepsTaken++;
                if (names[i].Equals(itemsToFind,
                    StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine($"Found Item at index {i}");
                    break;
                }
            }
            Console.WriteLine($"Steps taken {stepsTaken}");

            //3. 
        }
    }
}
