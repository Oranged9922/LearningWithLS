// The fifth project named "ListLearner" is designed to introduce
// Lists and their methods.
// 
// This console application introduces the concept of a List and
// the methods that can be used with it. It shows how to add items
// to a list, display the items, access and modify items,
// remove items, check if an item exists, and clear the list.
// The Count property is also introduced to get the number of items in the list.

namespace _05_ListLearner
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Introduction to Lists
            List<string> shoppingList = new List<string>();
            shoppingList.Add("Apples");
            shoppingList.Add("Bananas");
            shoppingList.Add("Oranges");

            // Display elements of a List
            Console.WriteLine("Shopping List:");
            foreach (string item in shoppingList)
            {
                Console.WriteLine(item);
            }

            // Accessing elements from a List
            Console.WriteLine($"\nThe first item on the list is: {shoppingList[0]}");

            // Modifying elements in a List
            shoppingList[1] = "Strawberries";
            Console.WriteLine("\nAfter modification, the second item on the list is: " + shoppingList[1]);

            // Removing elements from a List
            shoppingList.Remove("Oranges");
            Console.WriteLine("\nShopping List after removing Oranges:");
            foreach (string item in shoppingList)
            {
                Console.WriteLine(item);
            }

            // Checking if an item exists in a List
            if (shoppingList.Contains("Apples"))
            {
                Console.WriteLine("\nApples are on the shopping list.");
            }
            else
            {
                Console.WriteLine("\nApples are not on the shopping list.");
            }

            // Clearing the List
            shoppingList.Clear();
            Console.WriteLine($"\nShopping List contains {shoppingList.Count} items after clearing.");
        }
    }
}
