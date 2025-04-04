namespace LoopAndStringHandler.Library.Utilities;

internal class OutputUtil
{
    internal static void PrintErrorMessage(string errorMessage)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(errorMessage);
        Console.ResetColor();
    }
    internal static void PrintSuccessMessage(string successMessage)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(successMessage);
        Console.ResetColor();
    }
}
