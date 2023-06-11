using System;

// Create a class named MathOperations
class MathOperations
{
    // Create a void method named PerformOperation that takes two integers as parameters
    public void PerformOperation(int firstNumber, int secondNumber)
    {
        // Perform a math operation on the first number
        int result = firstNumber * 2;

        // Display the second number to the screen
        Console.WriteLine("Second Number: " + secondNumber);
    }
}

class Program
{
    static void Main()
    {
        // Instantiate the MathOperations class
        MathOperations mathOperations = new MathOperations();

        // Call the PerformOperation method, passing in two numbers
        mathOperations.PerformOperation(5, 10);

        // Call the PerformOperation method, specifying the parameters by name
        mathOperations.PerformOperation(firstNumber: 3, secondNumber: 8);

        Console.ReadLine();
    }
}
