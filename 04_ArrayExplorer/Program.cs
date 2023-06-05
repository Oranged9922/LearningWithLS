// The fourth project, "ArrayExplorer", introduces the
// concept of arrays and basic operations with them. 
//
// This console application creates a single-dimensional
// array and a multi-dimensional array, and demonstrates accessing and
// modifying elements, as well as iterating through the arrays using loops.
// The Length property and the GetLength method are introduced to get the size of the array.
namespace _04_ArrayExplorer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Introduction to arrays
            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine("The elements of the 'numbers' array are:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            // Accessing array elements
            Console.WriteLine("\nThe first number in the array is: " + numbers[0]);
            Console.WriteLine("The last number in the array is: " + numbers[numbers.Length - 1]);

            // Modifying array elements
            numbers[0] = 10;
            Console.WriteLine("\nAfter modification, the first number in the array is: " + numbers[0]);

            // Introduction to multi-dimensional arrays
            int[,] matrix = new int[3, 3]
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            Console.WriteLine("\nThe elements of the 'matrix' array are:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
