using System;
class Program
{
    static int add(int a, int b)
    {
        return a + b;
    }
    static double add(double a, double b)
    {
        return a + b;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Int addition: " + add(5, 10));
        Console.WriteLine("Double addition: " + add(5.5, 10.5));
    }
}