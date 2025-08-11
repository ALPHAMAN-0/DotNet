using System;
namespace Encapsulation
{
    class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.SetName("John Doe");
            person.SetAge(30);
            person.ShowInfo();
        }
    }
}