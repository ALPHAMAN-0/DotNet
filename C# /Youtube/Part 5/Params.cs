using System;
namespace ParamsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNumbers(1, 2, 3, 4, 5);
        }

        static void PrintNumbers(params int[] numbers)
        {
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}