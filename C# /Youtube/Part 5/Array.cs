using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Array elements:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        string[] names = new string[4];
        foreach (string name in names)
        {
            Console.WriteLine("Enter a name:");
            names[i] = Console.ReadLine();
        }
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}
