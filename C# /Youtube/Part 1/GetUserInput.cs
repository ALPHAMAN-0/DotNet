using System;
namespace GetUserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            string? name = null; // Allowed: name can be null
            string name2 = null; // Warning: name2 should not be null (with nullable enabled)

            name2 = Console.ReadLine();
            Console.WriteLine("Hello, " + name2 + "!");

            int myage;
            myage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are " + myage + " years old.");

            // use input always string when try to input number we need to convert into string
        }
    }
}