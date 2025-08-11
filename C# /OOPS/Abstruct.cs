using System;
namespace Abstruct
{
    abstract class Animal
    {
        public abstract void MakeSound();
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal myDog = new Dog();
            Animal myCat = new Cat();

            myDog.MakeSound();
            myCat.MakeSound();
        }
    }
}