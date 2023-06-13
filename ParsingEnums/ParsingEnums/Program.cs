using System;

namespace ParsingEnums
{
    class Program
    {
        // create an enum for the days of the week
        public enum DaysofWeek
        {
            Monday, 
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            bool isvalid = false;
            while (!isvalid)
            {
                try
                {
                    //prompt the user to enter the current day of the week.
                    Console.WriteLine("Enter the current day of the week");
                    string dayinput = Console.ReadLine();
                    //Assign the value to a variable of that enum data type you created.
                    DaysofWeek day = (DaysofWeek)Enum.Parse(typeof(DaysofWeek), dayinput);
                    Console.WriteLine("Have a nice " + day);
                    Console.ReadLine();
                    isvalid = true;

                }

                catch (ArgumentException ex)
                {
                    Console.WriteLine("Please enter an actual day of the week.");
                }
            }

        }
    }
}
