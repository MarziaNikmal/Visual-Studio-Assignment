using System;

public class Program
{
    public static void Main()
    {
        // Creating two Employee objects and assigning values to their properties
        Employee employee1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
        Employee employee2 = new Employee { Id = 2, FirstName = "Jane", LastName = "Smith" };

        // Comparing the Employee objects using the overloaded "==" operator
        bool areEqual = employee1 == employee2;

        // Displaying the comparison result
        Console.WriteLine("Are the employees equal? " + areEqual);

        // Output: Are the employees equal? False
    }
}
public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Overloading the "==" operator to compare employees based on their Id
    public static bool operator ==(Employee employee1, Employee employee2)
    {
        if (ReferenceEquals(employee1, employee2))
        {
            return true;
        }

        if (ReferenceEquals(employee1, null) || ReferenceEquals(employee2, null))
        {
            return false;
        }

        return employee1.Id == employee2.Id;
    }

    // Overloading the "!=" operator by using the previously overloaded "=="
    public static bool operator !=(Employee employee1, Employee employee2)
    {
        return !(employee1 == employee2);
    }
}
