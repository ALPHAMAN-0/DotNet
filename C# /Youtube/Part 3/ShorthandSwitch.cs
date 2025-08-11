using System;
namespace ShorthandSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit = 5;
            string message = digit switch
            {
                1 => "One",
                2 => "Two",
                3 => "Three",
                4 => "Four",
                5 => "Five",
                _ => "Unknown"
            };
            Console.WriteLine(message);

            object number = 10;
            switch (number)
            {
                case int n when n > 0:
                    Console.WriteLine("Positive integer");
                    break;
                case int n when n < 0:
                    Console.WriteLine("Negative integer");
                    break;
                default:
                    Console.WriteLine("Not an integer");
                    break;
            }

            number = 5.5;
            string typeMessage = number switch
            {
                int _ => "integer",
                double _ => "double",
                string _ => "string",
                _ => "unknown"
            };
            Console.WriteLine(typeMessage);
        }
    }
}