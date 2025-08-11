using System;
namespace DeepCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            int[] deepCopy = new int[arr.Length];

            Array.Copy(arr, deepCopy, arr.Length);
            //if I change deep copy array, the main array will not change
            Console.WriteLine("Original array:");
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("After modifying original array:");
            arr[0] = 100;

            Console.WriteLine("Deep Copy Array:");
            foreach (int item in deepCopy)
            {
                Console.WriteLine(item);
            }
        }
    }
}