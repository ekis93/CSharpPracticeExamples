using System.ComponentModel.Design.Serialization;

namespace PracticeExercises;

public class ErrorHandlingExercise
{
    //Part 1 division
    // Create the method DivideNumbers(int dividend, int divisor) which return the quotient
    // Call the function from main and try to send in 0 as the divisor.
    // public float DivideNumbers(int dividend, int divisor)
    // {
    //     return (float)(dividend / divisor);
    // }
    
    
    // Part 2 - User Input
    // Let the user write a whole number using Console.ReadLine() and int.Parse().
    // Get the program to crash by inputting different types of values.
    // Handle those exceptions using a try-catch
    
    /// <summary>
    /// Lets the user write two whole numbers to the console which are then divided by each other.
    /// </summary>
    public void DivideNumbers()
    {
        bool success = false;
        while (!success)
        {
            Console.WriteLine("Please enter two whole numbers (dividend and divisor) separated by a single space.");
            string[] divisionTerms = Console.ReadLine()?.Split(' ') ?? [];
            
            try
            {
                int dividend = int.Parse(divisionTerms[0]);
                int divisor = int.Parse(divisionTerms[1]);
                decimal quotient = (decimal)dividend / divisor;
                Console.WriteLine($"{dividend} / {divisor} = {quotient}");
            }
            catch (Exception e) when (e is FormatException
                                     or IndexOutOfRangeException
                                     or OverflowException
                                     or DivideByZeroException)
            {
                PrintErrorMessage(e);
                continue;
            }
            
            success = true;
        }
    }
    
    /// <summary>
    /// Prints a short highlighted exception error message together with the stacktrace to the console.
    /// </summary>
    /// <param name="ex">The exception thrown</param>
    private void PrintErrorMessage(Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"\nERROR!:\n{ex.Message}\n\nStacktrace:\n{ex.StackTrace}\n");
        Console.ResetColor();
        Console.WriteLine($"Returning to the console\n");
    }
    
}