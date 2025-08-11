using System;

namespace MultidimensionalArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize a 2D array
            int[,] numbers = new int[3, 4]
            {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 }
            };

            // Accessing elements in a 2D array
            Console.WriteLine("Element at (0, 0): " + numbers[0, 0]);
            Console.WriteLine("Element at (1, 2): " + numbers[1, 2]);
            Console.WriteLine("Element at (2, 3): " + numbers[2, 3]);

            // Iterating through a 2D array
            Console.WriteLine("All elements in the 2D array:");
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.Write(numbers[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
