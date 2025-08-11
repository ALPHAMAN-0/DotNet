using System;

public class InstantNoodles
{
    public static void Main(string[] args)
    {

        string[] input = Console.ReadLine().Split();

        int x = int.Parse(input[0]);
        int y = int.Parse(input[1]);
        int m = int.Parse(input[2]);

        Console.WriteLine(x * y * m);

        
        

    }
}