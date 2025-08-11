using System;
namespace Constructor
{
    class Person
    {
        public string name;
        public int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        void ShowInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }

    };
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}