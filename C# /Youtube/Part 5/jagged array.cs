using System;
namespace jaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize a jagged array
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 2, 3 };
            jaggedArray[1] = new int[] { 4, 5, 6, 7 };
            jaggedArray[2] = new int[] { 8, 9 };

            // Accessing elements in a jagged array
            Console.WriteLine("Element at (0, 0): " + jaggedArray[0][0]);
            Console.WriteLine("Element at (1, 2): " + jaggedArray[1][2]);
            Console.WriteLine("Element at (2, 1): " + jaggedArray[2][1]);

            // Iterating through a jagged array
            Console.WriteLine("All elements in the jagged array:");
            foreach (var innerArray in jaggedArray)
            {
                foreach (var item in innerArray)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write(jaggedArray[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}