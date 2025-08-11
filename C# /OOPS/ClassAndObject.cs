using System;
namespace ClassAndObject
{
    class Person
    {
        public string name;
        public int age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.name = "Siam Hossain";
            person.age = 20;

            Console.WriteLine("Name: " + person.name);
            Console.WriteLine("Age: " + person.age);

            Person person2 = new Person();
            person2.name = "John Doe";
            person2.age = 30;

            Console.WriteLine("Name: " + person2.name);
            Console.WriteLine("Age: " + person2.age);

        }
    }
}