// The third project is "LoopTrainer", which is about introducing
// loops including for, while, and do-while loops.
//
// In this simple console application, it starts with a countdown from 10
// using a for loop, then introduces a while loop that keeps asking for
// user input until the user types 'exit'. Finally, it introduces a
// do-while loop that asks the user to enter a number between
// 1 and 10 and repeats until the user enters 0.


namespace _03_LoopTrainer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Introduction to for loop
            Console.WriteLine("Countdown from 10 using a 'for' loop:");
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            // Introduction to while loop
            Console.WriteLine("\nType 'exit' to stop the loop.");
            string userInput = Console.ReadLine();
            while (userInput.ToLower() != "exit")
            {
                Console.WriteLine("You typed: " + userInput + ". Type 'exit' to stop the loop.");
                userInput = Console.ReadLine();
            }

            // Introduction to do-while loop
            int number;
            do
            {
                Console.WriteLine("\nEnter a number between 1 and 10. Enter 0 to exit.");
                string input = Console.ReadLine();
                if (!int.TryParse(input, out number))
                {
                    Console.WriteLine("That's not a valid number. Try again.");
                }
                else if (number > 0 && number <= 10)
                {
                    Console.WriteLine($"You've entered {number}");
                }
            } while (number != 0);
        }
    }
}
