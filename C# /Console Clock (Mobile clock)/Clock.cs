using System;
using System.Threading;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Current Time: " + DateTime.Now.ToString("HH:mm:ss"));
            Thread.Sleep(1000); // Wait for 1 second
        }
    }
}