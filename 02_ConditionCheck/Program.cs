// This project introduces learners to conditional statements like if,
// else, else if, and switch cases, along with the ternary operator.
//
// In this simple console application, the user is asked to enter a number.
// The application uses an if else statement to check if the number is positive,
// negative, or zero. It then introduces a switch case to handle specific
// cases based on user input, and finally introduces the ternary operator
// as a compact form of the if else statement.

namespace _02_ConditionCheck
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Introduction to if/else
            Console.WriteLine("Please enter a number:");
            string userInput = Console.ReadLine();
            int userNumber;

            if (int.TryParse(userInput, out userNumber))
            {
                if (userNumber > 0)
                {
                    Console.WriteLine("Your number is positive.");
                }
                else if (userNumber < 0)
                {
                    Console.WriteLine("Your number is negative.");
                }
                else
                {
                    Console.WriteLine("Your number is zero.");
                }
            }
            else
            {
                Console.WriteLine("That's not a valid number.");
            }

            // Introduction to switch
            Console.WriteLine("Enter a number between 1 and 5:");
            userInput = Console.ReadLine();

            if (int.TryParse(userInput, out userNumber) && userNumber >= 1 && userNumber <= 5)
            {
                switch (userNumber)
                {
                    case 1:
                        Console.WriteLine("You've entered one.");
                        break;
                    case 2:
                        Console.WriteLine("You've entered two.");
                        break;
                    case 3:
                        Console.WriteLine("You've entered three.");
                        break;
                    case 4:
                        Console.WriteLine("You've entered four.");
                        break;
                    case 5:
                        Console.WriteLine("You've entered five.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("That's not a valid number between 1 and 5.");
            }

            // Introduction to ternary operator
            Console.WriteLine("Enter a number:");
            userInput = Console.ReadLine();

            string message = int.TryParse(userInput, out userNumber)
                ? "You've entered a valid number."
                : "That's not a valid number.";

            Console.WriteLine(message);
        }
    }
}
