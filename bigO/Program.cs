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
            System.Console.WriteLine($"Time taken: {(DateTime.Now - startTime).Humanize()}");
        }
    }
}
