using System;
namespace OutRef
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            Console.WriteLine("Before: " + number);
            ModifyValue(ref number);

            Console.WriteLine("After: " + number);

            int newNumber = 10;

            ModifyTheValue(out newNumber);
            Console.WriteLine("New number: " + newNumber);
        }
        static void ModifyTheValue(out int value)
        {
            value = 10 + 1;
        }
        static void ModifyValue(ref int value)
        {
            value *= 2;
        }
    }
}