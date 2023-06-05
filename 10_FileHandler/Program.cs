// The tenth project, "FileHandler", is designed to
// introduce the basics of file handling in C#.
//
// This console application introduces the System.IO.File class and methods for creating a text file,
// writing data to it, reading data from it, appending data to it, and deleting it.
// These basic file operations are crucial to understand for tasks that involve persistent data storage.
namespace _10_FileHandler;
public class Program
{
    public static void Main(string[] args)
    {
        // Introduction to file writing
        string filePath = "./test.txt";
        string text = "Hello, File!";
        File.WriteAllText(filePath, text);

        Console.WriteLine($"Data written to {filePath}");

        // Introduction to file reading
        string readText = File.ReadAllText(filePath);
        Console.WriteLine($"Data read from {filePath}: {readText}");

        // Appending text to an existing file
        string appendText = " This is appended text.";
        File.AppendAllText(filePath, appendText);

        Console.WriteLine($"Data appended to {filePath}");

        // Reading the appended text
        string newText = File.ReadAllText(filePath);
        Console.WriteLine($"Updated data in {filePath}: {newText}");

        // Deleting the file
        File.Delete(filePath);
        Console.WriteLine($"Deleted the file at {filePath}");
    }
}
