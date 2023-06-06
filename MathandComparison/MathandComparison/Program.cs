using System;

namespace MathandComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Incmome Comparsion Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string hourlyrate1 = Console.ReadLine();
            Console.WriteLine("Hours worked per week");
            string hour1 = Console.ReadLine();
            int salary1 = Convert.ToInt32(hourlyrate1) * Convert.ToInt32(hour1) * 52;

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            string hourlyrate2 = Console.ReadLine();
            Console.WriteLine("Hours worked per week");
            string hour2 = Console.ReadLine();
            int salary2 = Convert.ToInt32(hourlyrate2) * Convert.ToInt32(hour2) * 52;

            Console.WriteLine("Annual Salary of Person 1:");
            Console.WriteLine(salary1);
            Console.WriteLine("Annual Salary of Person 2:");
            Console.WriteLine(salary2);

            Console.WriteLine("Does Person1 makes more money than Person2");
            bool isMore = salary1 > salary2;
            Console.WriteLine(isMore);
            Console.ReadLine();
        }
    }
}
