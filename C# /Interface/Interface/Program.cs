namespace program
{

    interface iID
    {
        void ID();
    }
    interface iCourse
    {
        void Course();
    }
    
    class Student : iID, iCourse
    {
        public void ID()
        {
            System.Console.WriteLine("Student ID");
        }

        public void Course()
        {
            System.Console.WriteLine("Student Course");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");
        }
    }
}