Overview Of Big O Notation
==========================

What is Good Code
-----------------

Good code in short is readable, maintainable and scalable. Big O helps us with the scalable part of good coding practices.

Why Big O Notation
------------------

The same algorithm or piece of code will might take variable amount of time to execute in different computer / machines. A machine with a much higher configuration like a enterprise grade server than say a basic laptop can run the same program much faster or vice verse. So it is not practical to measure the performance of an algorithm in terms of time as in a number like 10 milliseconds, since the run time heavily depends on the hardware the program is running on and even the language and/or runtime on which the program was written / intended to run.

Since computer are generally fast in this day and age, we as programmers need an alternate way of effeciently communicating the time an algorithm is expected to run regardless of the external factors like hardware/software and other factors. Enter Big O Notation...

What is Big O Notation
----------------------

Big O is used to defined time and space complexity of an algorithm which solves a single problem. Simply put it is the language software developers use to define how long an algorithm takes to run. It is also used to compare two algorithms aimed at solving the same problem, to identify which algorithm scales better, i.e., how the run time of each algorithm changes or if it changes at all as the number of input parameter or enumerbales increase.

```C#
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
```

![Big O Complexity](./imgs/bigocomplexitychart.jpg)

[Next O(n)](./Orderofn.md)

[Index](./index.md)
