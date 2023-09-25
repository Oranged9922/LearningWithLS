using System.Threading.Channels;

namespace _12_LinqLearner;
public class Program
{

    //public static void Main(string[] args)
    //{
    //    // Introduction to LINQ
    //    List<int> list = new List<int>() { 5, 7, 2, 4, 8, 6 };

    //    // LINQ query to find numbers greater than 5
    //    var greaterThanFive = from num in list
    //                          where num > 5
    //                          select num;

    //    Console.WriteLine("Numbers greater than 5:");
    //    foreach (int num in greaterThanFive)
    //    {
    //        Console.WriteLine(num);
    //    }

    //    // LINQ method syntax to find even numbers
    //    var evenNumbers = list.Where(num => num % 2 == 0);

    //    Console.WriteLine("\nEven numbers:");
    //    foreach (int num in evenNumbers)
    //    {
    //        Console.WriteLine(num);
    //    }

    //    // LINQ to find minimum, maximum and average of the list
    //    int min = list.Min();
    //    int max = list.Max();
    //    double average = list.Average();

    //    Console.WriteLine($"\nMinimum: {min}, Maximum: {max}, Average: {average}");
    //}

    public static void Main(string[] args)
    {
        var tasks = new Tasks();
        tasks.Run(Console.WriteLine);
    }
}
