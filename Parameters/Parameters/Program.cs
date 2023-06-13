using System;
using System.Collections.Generic;

public class Employee<T>
{
    public List<T> Things { get; set; }

    public Employee(List<T> things)
    {
        Things = things;
    }
}

public class Program
{
    public static void Main()
    {
        // Instantiate an Employee object with type "string" and assign a list of strings as the property value of Things
        List<string> stringList = new List<string> { "Apple", "Banana", "Cherry" };
        Employee<string> stringEmployee = new Employee<string>(stringList);

        // Instantiate an Employee object with type "int" and assign a list of integers as the property value of Things
        List<int> intList = new List<int> { 1, 2, 3, 4, 5 };
        Employee<int> intEmployee = new Employee<int>(intList);

        // Create a loop that prints all of the Things to the Console
        Console.WriteLine("String Things:");
        foreach (string thing in stringEmployee.Things)
        {
            Console.WriteLine(thing);
        }

        Console.WriteLine("\nInteger Things:");
        foreach (int thing in intEmployee.Things)
        {
            Console.WriteLine(thing);
        }
    }
}
