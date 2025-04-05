namespace LoopAndStringHandler.Library.Utilities;

/// <summary>
/// Provides methods to print messages to the console with specific colors.
/// </summary>
internal class OutputUtil
{
    /// <summary>
    /// Prints an error message in red color.
    /// </summary>
    /// <param name="errorMessage">The error message to print.</param>
    internal static void PrintErrorMessage(string errorMessage)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(errorMessage);
        Console.ResetColor();
    }

    /// <summary>
    /// Prints a success message in green color.
    /// </summary>
    /// <param name="successMessage">The success message to print.</param>
    internal static void PrintSuccessMessage(string successMessage)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(successMessage);
        Console.ResetColor();
    }
}
