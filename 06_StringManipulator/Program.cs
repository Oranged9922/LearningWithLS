// The sixth project, "StringManipulator", is focused on
// string manipulations and regular expressions. 
//
// In this console application, we introduce string concatenation
// and string interpolation for creating strings. We use some basic
// string methods like ToUpper, ToLower, Contains, and Replace.
// We also introduce regular expressions to validate a phone
// number format. Please note, the regular expression used here
// is very simple and might not be suitable for all phone
// number formats.

using System.Text.RegularExpressions;

namespace _06_StringManipulator;
public class Program
{
    public static void Main(string[] args)
    {
        // Introduction to string concatenation
        string hello = "Hello";
        string world = "World";
        string greeting = hello + ", " + world + "!";
        Console.WriteLine(greeting);

        // Introduction to string interpolation
        string name = "John";
        string greetingWithName = $"Hello, {name}!";
        Console.WriteLine(greetingWithName);

        // Introduction to string methods
        string uppercaseGreeting = greetingWithName.ToUpper();
        Console.WriteLine(uppercaseGreeting);

        string lowercaseGreeting = greetingWithName.ToLower();
        Console.WriteLine(lowercaseGreeting);

        bool containsHello = greetingWithName.Contains("Hello");
        Console.WriteLine($"Does the greeting contain 'Hello'? {containsHello}");

        string replacedGreeting = greetingWithName.Replace("Hello", "Hi");
        Console.WriteLine(replacedGreeting);

        // Introduction to regular expressions
        string phoneNumber = "123-456-7890";
        bool isPhoneNumber = Regex.IsMatch(phoneNumber, @"^\d{3}-\d{3}-\d{4}$");
        Console.WriteLine($"Is {phoneNumber} a valid phone number? {isPhoneNumber}");
    }
}
