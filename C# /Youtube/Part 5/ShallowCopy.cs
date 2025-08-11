using System;
namespace ShallowCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };

            int[] sharllowCopy = arr;

            //if i change sharllow array i will change main array
            foreach (int item in sharllowCopy)
            {
                Console.WriteLine(item);
            }

            sharllowCopy[0] = 100;

            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}