using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first number:");
        string input1 = Console.ReadLine();

        Console.WriteLine("Enter the second number:");
        string input2 = Console.ReadLine();

        try
        {
            // Use int.TryParse to safely attempt conversion
            if (!int.TryParse(input1, out int num1) || !int.TryParse(input2, out int num2))
            {
                throw new FormatException("One or both inputs are not in a valid integer format.");
            }

            // Attempt to perform the division
            if (num2 == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }

            // Perform division inline
            double result = (double)num1 / num2;

            // Print the result if no exception occurs
            Console.WriteLine($"The result of the division is: {result}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: One or both inputs are too large to be represented as an integer.");
        }
        catch (Exception ex)
        {
            // Catch any other unexpected exceptions
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }

        Console.WriteLine("Program has ended. Press any key to exit.");
        Console.ReadKey();
    }
}
