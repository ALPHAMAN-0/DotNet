using System;
namespace ClassMethod
{
    class Person
    {
        public string name;
        public int age;
        // what if constructor call private
        /*
            private Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
            public static person create(string name,int age){
                return new Person(name,age);
            }

            // main function thake Person p = Person.create("siam",20);
        
            if i want to save using method
            public void SetValue(string n,int a){
                name = n;
                age = a;
            }

            main function thake 
            when create object like p
            then p.SetValue("new name", 30);

        */


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
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("siam hossain", 20);

            Person person2 = new Person("samiul islam", 21);

            person.ShowInfo();
            person2.ShowInfo();

        }
    }
}