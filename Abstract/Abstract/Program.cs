using System;

namespace Abstract
{
   public abstract class person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public abstract void SayName();
    }
}

namespace Abstract
{
    public class Employee : person
    {
        public int id { get; set; }
        public override void SayName()
        {
            Console.WriteLine("Name :" + FirstName + " " + LastName);
        }
    }

}

namespace Abstract
{
    class program
    {
        static void Main(string[] args)
        {
            Employee sam = new Employee() { FirstName = "Sample", LastName = "Student" };
            sam.SayName();
            Console.ReadLine();
        }
    }
}
