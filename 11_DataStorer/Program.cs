// The eleventh project, "DataStructures", would introduce the basics
// of common data structures in C#, including arrays, multi-dimensional
// arrays, and collections such as List, Dictionary, Stack, and Queue.
//
// This console application introduces basic data structures: arrays,
// multi-dimensional arrays, lists, dictionaries, stacks, and queues.
// For each data structure, it shows how to initialize it, add elements,
// and iterate over the elements. For stacks and queues, it also
// demonstrates popping and dequeuing elements.

namespace _11_DataStorer;
public class Program
{
    public static void Main(string[] args)
    {
        // Introduction to arrays
        int[] array = new int[] { 1, 2, 3, 4, 5 };
        Console.WriteLine("Array elements:");
        foreach (int num in array)
        {
            Console.WriteLine(num);
        }

        // Introduction to multi-dimensional arrays
        int[,] multiArray = new int[2, 2] { { 1, 2 }, { 3, 4 } };
        Console.WriteLine("\nMulti-Dimensional array elements:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(multiArray[i, j] + " ");
            }
            Console.WriteLine();
        }

        // Introduction to Lists
        List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
        Console.WriteLine("\nList elements:");
        foreach (int num in list)
        {
            Console.WriteLine(num);
        }

        // Introduction to Dictionaries
        Dictionary<string, string> dict = new Dictionary<string, string>()
            {
                { "first", "one" },
                { "second", "two" },
                { "third", "three" }
            };
        Console.WriteLine("\nDictionary elements:");
        foreach (KeyValuePair<string, string> item in dict)
        {
            Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
        }

        // Introduction to Stacks
        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        Console.WriteLine("\nStack elements after push operations:");
        foreach (int num in stack)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine($"Popped element from stack: {stack.Pop()}");

        // Introduction to Queues
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        Console.WriteLine("\nQueue elements after enqueue operations:");
        foreach (int num in queue)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine($"Dequeued element from queue: {queue.Dequeue()}");
    }
}
