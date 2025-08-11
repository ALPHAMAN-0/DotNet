using System;
namespace ConstantAndMultiple
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.14159;   // constant variable assign always assigned value first
            double radius = 5.0;
            double area = PI * radius * radius;

            Console.WriteLine("Area of the circle: " + area);
        }
    }
}
