using System;

// Define the IQuittable interface with a Quit() method
public interface IQuittable
{
    void Quit();
}

// Employee class that inherits from IQuittable interface
public class Employee : IQuittable
{
    public string Name { get; set; }

    // Implementation of the Quit() method from the interface
    public void Quit()
    {
        Console.WriteLine("Employee {0} has quit the job.", Name);
        // Additional logic for quitting the job can be added here
    }
}

public class Program
{
    public static void Main()
    {
        // Create an Employee object
        Employee employee = new Employee
        {
            Name = "John Doe"
        };

        // Create an object of type IQuittable using polymorphism
        IQuittable quittable = employee;

        // Call the Quit() method on the IQuittable object
        quittable.Quit();

        // Output: Employee John Doe has quit the job.
    }
}
