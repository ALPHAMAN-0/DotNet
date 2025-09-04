namespace program
{
    class Program
    {
        public sealed class Calculator
        {
            public int Add(int a, int b)
            {
                return a + b;
            }
        }
       //sealed class we can not inheritanc for base class
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(5, 3);
            System.Console.WriteLine("The sum is: " + result);
        }
    }
}