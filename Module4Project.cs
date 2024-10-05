using System;

namespace DivisionExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueRunning = true;

            while (continueRunning)
            {
                Console.Clear();
                Console.WriteLine("Division Calculator");
                Console.WriteLine("-------------------");
                Console.WriteLine("Enter two numbers to perform division.");

                Console.Write("Enter the first number: ");
                string input1 = Console.ReadLine();
                
                Console.Write("Enter the second number: ");
                string input2 = Console.ReadLine();

                bool success = DivideNumbers(input1, input2);

                if (success)
                {
                    Console.WriteLine("Do you want to perform another division? (yes/no)");
                    string response = Console.ReadLine().ToLower();
                    if (response != "yes" && response != "y")
                    {
                        continueRunning = false;
                    }
                }
                else
                {
                    Console.WriteLine("Do you want to try again? (yes/no)");
                    string response = Console.ReadLine().ToLower();
                    if (response != "yes" && response != "y")
                    {
                        continueRunning = false;
                    }
                }
            }

            Console.WriteLine("Thank you for using the Division Calculator. Goodbye!");
        }

        static bool DivideNumbers(string num1, string num2)
        {
            try
            {
                // Convert the input strings to integers
                int number1 = Convert.ToInt32(num1);
                int number2 = Convert.ToInt32(num2);

                // Perform the division
                int result = number1 / number2;

                // Print the result if no exceptions occur
                Console.WriteLine($"Result: {number1} / {number2} = {result}");
                return true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: One or both inputs are not valid integers. Please enter valid numbers.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero is not allowed. Please enter a non-zero value for the second number.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: The number entered is too large or too small. Please enter a number within a valid range.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }

            return false;
        }
    }
}
