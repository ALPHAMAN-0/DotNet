using System;
namespace ThisAndReadOnly
{
    public class Person
    {
        public readonly int age;
        public Person(int age)
        {
            this.age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person(30);
            Console.WriteLine("Age: " + p.age);

            Person p1 = p;
            p1.age = 35; // This line will cause a compile-time error because 'age' is readonly.

        }
    }
}