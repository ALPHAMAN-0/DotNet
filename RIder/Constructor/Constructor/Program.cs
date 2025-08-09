using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    // Interface example
    public interface IExampleInterface
    {
        void DoSomething();
    }

    // Base class
    public class BaseClass
    {
        protected int baseField;
        
        public BaseClass(int value)
        {
            baseField = value;
        }
        
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Base class value: {baseField}");
        }
    }
    
    // Derived class implementing interface
    public class DerivedClass : BaseClass, IExampleInterface
    {
        private string name;
        
        public DerivedClass(string name, int baseValue) : base(baseValue)
        {
            this.name = name;
        }
        
        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}, Base value: {baseField}");
        }
        
        public void DoSomething()
        {
            Console.WriteLine("Interface method implemented!");
        }
    }
    
    // Static utility class
    public static class Utilities
    {
        public static void PrintMessage(string message)
        {
            Console.WriteLine($"Message: {message}");
        }
    }
    
    // Main program class
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, C#!");
            
            // Creating objects
            DerivedClass obj = new DerivedClass("Example", 100);
            obj.DisplayInfo();
            obj.DoSomething();
            
            // Using static method
            Utilities.PrintMessage("This is a utility method");
            
            // Collection example
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            
            // LINQ example
            var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
            Console.WriteLine("Even numbers:");
            foreach (var number in evenNumbers)
            {
                Console.WriteLine(number);
            }
            
            Console.ReadKey();
        }
    }
}