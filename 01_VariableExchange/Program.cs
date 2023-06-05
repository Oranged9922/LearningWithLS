// The first project named "VariableExchange" is an introductory
// project which focuses on understanding the concept of variables,
// data types, and basic console input/output operations.
//
// In this simple console application, the user is asked to enter a
// number. The application uses an if else statement to check if the
// number is positive, negative, or zero. It then introduces a switch
// case to handle specific cases based on user input, and finally
// introduces the ternary operator as a compact form of the if else
// statement.

namespace _01_VariableExchange
{
    class Program
    {
        static void Main(string[] args)
        {
            // Introduction to integer variables
            int myNumber = 10;
            Console.WriteLine($"The value of myNumber is: {myNumber}");

            // Introduction to string variables
            string myName = "John";
            Console.WriteLine($"Hello, my name is: {myName}");

            // Introduction to boolean variables
            bool isRaining = false;
            Console.WriteLine($"Is it raining today? {isRaining}");

            // Introduction to double variables
            double myHeight = 1.83;
            Console.WriteLine($"My height is: {myHeight} meters");

            // Introduction to Console input
            Console.WriteLine("\nNow, let's have some interaction. What's your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}. Nice to meet you!");

            // Change value of a variable
            myNumber = 20;
            Console.WriteLine($"The new value of myNumber is: {myNumber}");

            // Exchange variable values
            Console.WriteLine("\nLet's exchange some values. Give me a number:");
            string userInput = Console.ReadLine();
            int userNumber;
            if (int.TryParse(userInput, out userNumber))
            {
                int temp = myNumber;
                myNumber = userNumber;
                userNumber = temp;
                Console.WriteLine($"Now, myNumber is: {myNumber} and your number is: {userNumber}");
            }
            else
            {
                Console.WriteLine("Sorry, that's not a valid number.");
            }
        }
    }
}
