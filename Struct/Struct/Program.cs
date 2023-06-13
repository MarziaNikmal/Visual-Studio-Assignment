using System;

public struct Number
{
    public decimal Amount { get; }

    public Number(decimal amount)
    {
        Amount = amount;
    }
}

public class Program
{
    public static void Main()
    {
        // Create an object of data type Number and assign an amount to it
        Number number = new Number(10.5m);

        // Print the amount to the console
        Console.WriteLine("Amount: " + number.Amount);
    }
}

