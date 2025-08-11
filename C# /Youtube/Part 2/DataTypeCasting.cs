using System;

namespace DataTypeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = 9.78;
            int roundedNum = (int)Math.Round(num);

            string numString = num.ToString();
            Console.WriteLine("Original Number: " + num);
            Console.WriteLine("Rounded Number: " + roundedNum);

            Console.WriteLine("String Representation: " + numString);

            //automatic conversion
            char s = 'a';
            int ch = s;
            Console.WriteLine("Character: " + s);
            Console.WriteLine("ASCII Value: " + ch);

            //manual conversion
            double d = 9.78;
            int i = (int)d;
            Console.WriteLine("Double Value: " + d);
            Console.WriteLine("Integer Value: " + i);

            int j = 10;
            double k = Convert.ToDouble(j);
            Console.WriteLine("Integer Value: " + j);
            Console.WriteLine("Double Value: " + k);

            //premative datatype
            string numberStr = "123";
            int numberInt = int.Parse(numberStr);
            Console.WriteLine("String Value: " + numberStr);
            Console.WriteLine("Parsed Integer Value: " + numberInt);

            // TryParse example
            string number = "123456789";
            long result;
            bool success = long.TryParse(number, out result);
            if (success)
            {
                Console.WriteLine("String Value: " + number);
                Console.WriteLine("Parsed Long Value: " + result);
            }
            else
            {
                Console.WriteLine("Failed to parse the string to long.");
            }
            Console.ReadKey(); // work for waiting in terminal
        }
    }
}
// Implicit meaning Automatic Conversion
// when try one data type convert large data type
// char < int < long < float < double


// Explicit manual conversion
// when try one data type convert small data type
// double < float < long < int < char using manual casting