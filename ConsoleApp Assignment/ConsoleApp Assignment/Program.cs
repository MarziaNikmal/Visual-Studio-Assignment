using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 1
            // Create a one dimensional Array of strings

            string[] wordStart =
            {
                "Welcome to the The",
                "I am the Instructor",
                "Our goal is to provide our students with a"
            };
            string[] wordend =
            {
                "Academy.",
                ".",
                "Learning Expirence."
            };
            List<string> responses = new List<string>();
            //Ask the user to inout some text
            Console.WriteLine("Please enter a noun:");
            responses.Add(Console.ReadLine());
            Console.WriteLine("Pleas enter the name of some infamous:");
            responses.Add(Console.ReadLine());
            Console.WriteLine("Please enter an adjective:");
            responses.Add(Console.ReadLine());

            // create a loop that goes through each string in Array and adding users text to array
            for (int i = 0; i < wordStart.Length; i++)
            {
                wordStart[i] = responses[i];
                Console.WriteLine(wordStart[i] + wordend[i]);
            }
            Console.ReadLine();
            Console.WriteLine("The strings we used:");

            //Then create a loop that prints off each string of Array in a spearate line
            for (int i = 0; i < wordStart.Length; i++) 
            { Console.WriteLine(wordStart[i] + wordend[i]);
                //part 2
                //create an infinite loop
                //fix the loop//i--;
            }
            Console.ReadLine();

            //part 3
            Console.WriteLine("Is that a ghost?!");
            StringBuilder boo = new StringBuilder();
            boo.Append("B");
            // A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator.
            while (boo.Length < 10)
            {
                boo.Append("o");
            }
            boo.Append("!");
            Console.ReadLine();
            Console.WriteLine("boo");
            Console.ReadLine();
            StringBuilder ahh = new StringBuilder();
            ahh.Append("A");
            //Add another loop where the comparison that’s used to determine whether to continue iterating the loop is a “<=” operator.
            while(ahh.Length <= 10)
            {
                ahh.Append("h");

            }
            ahh.Append("!");
            Console.WriteLine(ahh);
            Console.ReadLine();

            //part 4
            //A list of strings where each item in the list is unique.
            List<string> teams = new List<string>() { "Bucks", "Raptors", "Celtics", "Heat", "Pacers", "76ers", "Nets",
                "Magic", "Wizards", "Horneets", "Bulls", "Knicks", "Pistons", "Hawks", "Cavaliers" };
            Console.WriteLine("NBA Eastren Confrence Standings");
            // Ask the user to input text to search for the list
            Console.WriteLine("Enter team name");
            int standing = 0;
            bool isvalid = false;
            int index = 0;
            // A loop that iterates through the list and then displays the index of the list item that contains matching text on the screen.
            while(!isvalid)
            {
                int i2 = 0;
                string teamrequest = Console.ReadLine();
                foreach (string team in teams)
                {
                    if (teamrequest == team)
                    {
                        standing = i2 + 1;
                        index = i2;

                    }
                    i2++;
                }
                //Add code to check if the user put in text that isn't on the list and, if they did, tell the user their input is not on the list.

                if (standing == 0)
                {
                    Console.WriteLine("That is not a valid team name. Enter again :");

                }
                //Add code that stops the loop from executing once a match has been found.
                else
                {
                    isvalid = true;
                }


            }

            Console.WriteLine("Processing.... Index is: " + index + ". So...");
            Console.WriteLine("Standing is :" + standing);
            Console.ReadLine();

            // Part 5
            //A list of strings that has at least two identical strings in the list. Ask the user to select text to search for in the list.
            List<string> tables = new List<string>() { "Reserved", "Vacant", "Taken", "Vacant", "Vacant", "Reserved", "Taken" };
            Console.WriteLine("Welcome to swell taco! \n Due to COVID we have computerized check-in. \n If you have a reservation type " + "\"Reserved\". \n If you are joining a party which is already here type \"Taken\". \n Otherwise type \"Vacant\".");
            // Ask another user to insert 
            Console.WriteLine("Enter Selection");
            string selection = Console.ReadLine();
            while(!(selection == "Vacant" || selection == "Reserved" || selection == "Taken"))
            {
                // add code to tell user they have enetred answer which isnt in the lisst
                Console.WriteLine("Please enter one of the 3 choices :");
                selection = Console.ReadLine();

            }
            Console.WriteLine("The tables that match your selection are numberd:");

            //Create a loop that iterates through the list and then displays the indices of the list that contain matching text on the screen. Ensure to remove any break statements that may prevent your code from returning multiple matches.

            for (int i3 =0; i3 < tables.Count; i3++)
            {
                if (selection == tables[i3])
                {
                    Console.WriteLine(i3);
                }
            }
            Console.ReadLine();

            // Part 6
            // Create a list of strings that has at least two identical strings in the list. 
            List<string> names = new List<string>() { "Bob", "Jim", "Tiffany", "Bob", "Kat", "Mary", "Mary" };
            List<string> repeatcheck = new List<string>();
            Console.WriteLine("Class Roster: ");

            //Create a foreach loop that evaluates each item in the list,

            foreach(string name in names)
            {
                Console.WriteLine(name);
                if (repeatcheck.Contains(name))
                {
                    Console.WriteLine("This name has been repeated. \n Use last name initial when referring to this student.");
                }
                else
                {
                    Console.WriteLine("This name has not been repeated");
                }
                repeatcheck.Add(name);
            }
            Console.ReadLine();
        }
    }
}
