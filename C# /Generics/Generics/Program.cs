namespace program
{
    public class genericClass
    {
        private object objectValue;
        public genericClass(object obj)
        {
            objectValue = obj;
        }
        public void printValue()
        {
            System.Console.WriteLine(objectValue.ToString());
        }
    }
    //generic class
    public class Box<T>
    {
        private T value;
        public Box(T val)
        {
            value = val;
        }
        public T GetValue()
        {
            return value;
        }
        public void setValue(T val)
        {
            value = val;
        }
    }
   
    
    public class Program
        {
        //generic method
        public static void genericMethod<T>(T value)
        {
            System.Console.WriteLine(value);
        }
        public static void Main(string[] args)
        {
            //generic class
            genericClass intObject = new genericClass(42);
            genericClass stringObject = new genericClass("Hello, Generics!");

            intObject.printValue();
            stringObject.printValue(); // Output: Hello, Generics!

            //dynamic type
            dynamic value = 100;
            Console.WriteLine($"The value is: {value}");

            value = "Now I'm a string!";
            Console.WriteLine($"The value is: {value}");


            //box type
            Box<int> intBox = new Box<int>(123);
            Box<string> strBox = new Box<string>("Generics are powerful!");
            Console.WriteLine($"Integer Box contains: {intBox.GetValue()}");
            Console.WriteLine($"String Box contains: {strBox.GetValue()}");

            //generic method
            genericMethod<int>(10);
            genericMethod<string>("Generic Method Call");
            genericMethod<double>(3.14);
        }
        }
}
          
