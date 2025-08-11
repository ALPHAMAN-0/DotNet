using System;
namespace SetGetMethod
{
    class person
    {
        private string name;
        private int age;
        public void SetName(string s)
        {
            name = s;
        }
        public string GetName()
        {
            return name;
        }
        public void SetAge(int a)
        {
            age = a;
        }
        public int GetAge()
        {
            return age;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            person p = new person();
            p.SetName("John");
            p.SetAge(30);
            Console.WriteLine("Name: " + p.GetName());
            Console.WriteLine("Age: " + p.GetAge());
        }
    }
}