namespace program
{
    public abstract class University
    {
        public abstract void ID();
    }
    public abstract class UniversityAddress
    {
        public abstract void Address();
    }
    public class AIUB : University 
    {
        public override void ID()
        {
            Console.WriteLine("AIUB ID");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            University myUniversity = new AIUB();
            myUniversity.ID();
        }
    }

}
