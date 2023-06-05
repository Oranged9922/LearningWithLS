// The fifteenth project, "TaskMaster", is designed to
// introduce the concepts of asynchronous programming
// in C# using Tasks.
//
// In this console application, we first introduce the Task class by creating
// a new Task that performs a simulated work (a delay) and writing a message
// before and after the work. We start the Task and wait for it to complete
// with await. Then, we introduce the async/await keywords by defining an
// asynchronous method AsyncMethod that simulates some asynchronous operation
// using Task.Delay and writing a message before and after the operation.
// We call this method from the Main method and write a message before and after
// the call to illustrate that the method runs asynchronously.
namespace _15_TaskMaster;
public class Program
{
    static async Task Main(string[] args)
    {
        // Introduction to Tasks
        Task task = new Task(() =>
        {
            Console.WriteLine("Task is running...");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Task completed!");
        });

        task.Start();
        await task;

        // Introduction to async/await
        Console.WriteLine("Before async method call");
        await AsyncMethod();
        Console.WriteLine("After async method call");
    }

    static async Task AsyncMethod()
    {
        Console.WriteLine("Async method started");
        await Task.Delay(2000);  // Simulating some async operation
        Console.WriteLine("Async method completed");
    }
}
