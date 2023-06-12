using System;

namespace MethodsandObjects
{
   public class person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayName()
        {
            Console.WriteLine("Name :" + this.FirstName + " " + this.LastName);
        }
    }
}

namespace MethodsandObjects
{
    public class Employee : person
    {
        public int Id { get; set; }
    }
}



namespace MethodsandObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee sam = new Employee() { FirstName = "Sample", LastName = "Student" };
            sam.SayName();
            Console.ReadLine();
        }
    }
}
