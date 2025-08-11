using System;

namespace EnumExample
{
    enum Days
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Loop through enum values
            foreach (Days day in Enum.GetValues(typeof(Days)))
            {
                Console.WriteLine(day);
            }
        }
    }
}