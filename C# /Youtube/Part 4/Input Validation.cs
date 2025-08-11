using System;
namespace InputValidation
{
    class Program
    {
        static void Validation()
        {
            
            while (true)
                {
                    string input = Console.ReadLine() ?? "";
                    input = input.ToLower();
                    if (input == "exit")
                    {
                        Console.WriteLine("Exiting...");
                        break;
                    }
                    else
                    {
                        int num = Convert.ToInt32(input);
                        Console.WriteLine($"You entered: {num * num}");
                    }
                }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers to square them. Type 'exit' to quit.");
            Validation();
            Console.WriteLine("Program has ended.");
        }
    }
}