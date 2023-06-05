// The seventh project, "ExceptionCatcher", is aimed at introducing
// the concept of exception handling and creating custom exceptions.
//
// This application starts by introducing basic exception handling
// with try-catch. Then, it shows how to handle multiple types of
// exceptions in one try-catch block. Finally, it introduces the
// concept of custom exceptions, creating a CustomException class
// that extends the Exception base class.

namespace _07_ExceptionCatcher;
public class Program
{
    public static void Main(string[] args)
    {
        // Introduction to basic exception handling
        try
        {
            Console.WriteLine("Enter a number:");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            Console.WriteLine($"You entered: {number}");
        }
        catch (FormatException)
        {
            Console.WriteLine("That's not a valid number.");
        }

        // Handling multiple exceptions
        try
        {
            Console.WriteLine("\nEnter a number between 1 and 5:");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            if (number < 1 || number > 5)
                throw new ArgumentOutOfRangeException();

            Console.WriteLine($"You entered: {number}");
        }
        catch (FormatException)
        {
            Console.WriteLine("That's not a valid number.");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Number should be between 1 and 5.");
        }

        // Custom exception
        try
        {
            Console.WriteLine("\nEnter a word:");
            string input = Console.ReadLine();
            if (input.ToLower() == "error")
                throw new CustomException("The word 'error' is not allowed.");

            Console.WriteLine($"You entered: {input}");
        }
        catch (CustomException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

// Creating a custom exception
public class CustomException : Exception
{
    public CustomException()
    {
    }

    public CustomException(string message) : base(message)
    {
    }

    public CustomException(string message, Exception inner) : base(message, inner)
    {
    }
}
}
