using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number");
            string userInput = Console.ReadLine();

            int number = Convert.ToInt32(userInput);
            int result1 = number * 50;
            Console.WriteLine("Multiplication Result : " + result1);

            int result2 = number + 25;
            Console.WriteLine("Addition Result : " + result2);

            double result3 = number / 12.5;
            Console.WriteLine("Division Result : " + result3);

            bool isGreaterThan50 = number > 50;
            Console.WriteLine("Is Greater than 50? : " + isGreaterThan50);

            int remainder = number % 7;
            Console.WriteLine("Remainder : " + remainder);

            Console.ReadLine();
        }
    }
}
