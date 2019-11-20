using Humanizer;
using System;

namespace bigO
{
    class Program
    {
        static void Main(string[] args)
        {
            //BigOnExample1();
            //BigOnExample2();

            //3. Log All Pairs Of Array
            var numbers = new int[] { 1, 2, 3, 4, 5, 6 };
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    Console.WriteLine($"Pair: {numbers[i]}, {numbers[j]}");
                }
            }
        }

        private static void BigOnExample2()
        {
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
        }

        private static void BigOnExample1()
        {
            //1. O(n) Function
            bigO.Example1.FindingNemo(new string[] { "manoj", "nandan",
            "saranya", "jack", "nemo", "karimeen" });
            var startTime = DateTime.Now;
            var nemoArray = "nemo".GetEnumerablePrePopulated(100000);
            bigO.Example1.FindingNemo(nemoArray);
            System.Console.WriteLine($"Time taken to run: {(DateTime.Now - startTime).Humanize()}");
        }
    }
}
