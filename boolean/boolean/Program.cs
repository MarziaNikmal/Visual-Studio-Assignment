using System;

namespace boolean
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Application");
            Console.WriteLine("What is your age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had DUI? (YES or NO)");
            string answer = Console.ReadLine().ToLower();
            bool dui = answer == "yes";
            Console.WriteLine("How many speeding tickets do you have");
            int tickets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qualified for Insurance?");
            bool qualified = (age > 15) && !dui && (tickets <= 3);
            Console.WriteLine(qualified);






        }
    }
}
