using System;
using System.Collections.Generic;

namespace ArrayandLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array of string
            string[] colorArray = { "Red", "Orange", "Yellow", "Green", "Blue", "Black", "Pink", "Purple", "Brown", "White" };
            //Ask the user to put a number to display the string
            Console.WriteLine("Select a number between 0 to 9: ");
            int stringSelect = Convert.ToInt32(Console.ReadLine());
            bool validStirng = false;

            while (!validStirng)
            {
                try
                {
                    Console.WriteLine("Your favorite color is " + colorArray[stringSelect]);
                    validStirng = true;
                }

                catch
                {
                    Console.WriteLine("Sorry the number selcetion is invalid. Please select a number between 0 - 9.");
                    stringSelect = Convert.ToInt32(Console.ReadLine());
                }

            }

            // List of Strings
            List<string> occupationList = new List<string>()
            {
                "Data Analyst",
                "UX Designer",
                "Artist",
                "Teacher",
                "Lawyer",
                "Cowboy",
                "Athlete",
                "Podcast",
                "Software Developer",
                "QA Tester"

            };
            // Ask the user to entre a number to display the string at that index
            Console.WriteLine("\nSelect another numberbetween 0 - 9");
            int ListSelect = Convert.ToInt32(Console.ReadLine());
            bool validList = false;

            while (!validList)
            {
                try
                {
                    Console.WriteLine("Your new Occupation is :" + occupationList[ListSelect]);
                    validList = true;
                }
                //Add a message
                catch
                {
                    Console.WriteLine("Sorry the number selcetion is invalid. Please select a number between 0 - 9. ");
                    ListSelect = Convert.ToInt32(Console.ReadLine());
                }
            }

        }
    }
}
