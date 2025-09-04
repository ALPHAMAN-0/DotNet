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
    //generic Interface
    public interface IStorage<T>
    {
        void Add(T item);
        T Get(int index);
    }
    public class StringStorage : IStorage<string>
    {
        private List<string> items = new List<string>();
        public void Add(string item)
        {
            items.Add(item);
        }
        public string Get(int index)
        {
            return items[index];
        }
    }
    public delegate T GenericDelegate<T>(T a,T b);
    public class Program
    {
        //generic method
        static int add(int a, int b)
        {
            return a + b;
        }
        static string concatenate(string a, string b)
        {
            return a + b;
        }
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

            //generic delegate
            GenericDelegate<int> intDelegate = new GenericDelegate<int>(add);
            int result = intDelegate(5, 10);
            Console.WriteLine($"Integer Delegate Result: {result}");

            GenericDelegate<string> stringDelegate = new GenericDelegate<string>(concatenate);
            string strResult = stringDelegate("Hello, ", "World!");
            Console.WriteLine($"String Delegate Result: {strResult}");

            //list type
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            numbers.Add(6);
            Console.WriteLine("Numbers in the list:");
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
          
