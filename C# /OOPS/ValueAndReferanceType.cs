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

        public void ShowInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }

    };
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("John Doe", 30);
            person.ShowInfo();

            Person P1 = person; // reference type
            P1.name = "siam hossain"; // modifying the name through P1
            person.ShowInfo(); // Show updated info

            // value type reference
            int x = 10;
            int y = x; // y is a copy of x
            y = 20; // modifying y does not affect x
            Console.WriteLine("x: " + x + ", y: " + y);
        }
    }
}