using System;
namespace NameArguments
{
    class Program
    {
        static void Method(string FirstName, string LastName)
        {
            Console.WriteLine($"Hello {FirstName} {LastName}");
        }
        static void Main(string[] args)
        {
            Method(FirstName: "John", LastName: "Doe");
        }
    }
}