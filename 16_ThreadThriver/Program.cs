// The sixteenth project, "ThreadThriver", would introduce the
// concepts of multithreading in C#. 
// 
// In this console application, we first introduce System.Threading.Thread
// class by creating a new thread that runs the Count method.
// The Count method counts from 0 to 4 with a delay of one second between each count.
// The main thread also performs a similar counting operation. By observing the
// output, we can see that the Count method runs on a separate thread simultaneously
// with the main thread.
// 
// This is a simplified example. Multithreading can become quite complex when it
// comes to handling shared resources, thread synchronization, and other advanced topics.
namespace _16_ThreadThriver;
public class Program
{
    public static void Main(string[] args)
    {
        // Introduction to Threads
        Thread thread = new Thread(new ThreadStart(Count));
        thread.Start();

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Main Thread: {i}");
            Thread.Sleep(1000);
        }
    }

    public static void Count()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Secondary Thread: {i}");
            Thread.Sleep(1000);
        }
    }
}
