using System;
class MethodParameters {
    static void ParameterMethod(int a, int b)
    {
        Console.WriteLine("Parameter Method called",a + b);
    }
    static void DefaultParameterMethod(int a = 5, int b = 10)
    {
        Console.WriteLine("Default Parameter Method called", a + b);
    }
    static int ReturnMethod(int a, int b)
    {
        Console.WriteLine("Return Method called");
        return a + b;
    }
    static void NamedArgumentsMethod(int a, int b, int c)
    {
        Console.WriteLine("Named Arguments Method called", a + b + c);
    }
    static void Main(string[] args)
    {
        ParameterMethod(5, 10);
        DefaultParameterMethod();
        int result = ReturnMethod(5, 10);
        Console.WriteLine("Return Method result: " + result);
        NamedArgumentsMethod(c: 5, a: 10, b: 15);
    }
}