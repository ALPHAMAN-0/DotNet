using System;
namespace Classes
{
    class car
    {
        string color = "red";
        static void Main(string[] args)
        {
            car myCar = new car();
            Console.WriteLine("The color of the car is: " + myCar.color);
        }
    }
}