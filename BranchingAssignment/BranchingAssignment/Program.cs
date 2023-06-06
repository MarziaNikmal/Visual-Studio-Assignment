using System;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display the initial welcome message
            Console.WriteLine("Wellcome to Package Express. Please follow the instructions bellow.");
            // Prompt the user for the package weight
            Console.WriteLine("Please enter the package weight:");
            double weight = Convert.ToDouble(Console.ReadLine());

            // Check if the weight is greater than 50
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // End the program
            }

            // Prompt the user for the package dimensions
            Console.WriteLine("Please enter the package width:");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            double length = Convert.ToDouble(Console.ReadLine());

            // Calculate the dimensions total
            double dimensionsTotal = width + height + length;

            // Check if the dimensions total is greater than 50
            if (dimensionsTotal > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // End the program
            }

            // Calculate the quote
            double quote = (width * height * length * weight) / 100;

            // Display the quote to the user
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("F2"));
            Console.WriteLine("Thank you!");
        }
    }
}
