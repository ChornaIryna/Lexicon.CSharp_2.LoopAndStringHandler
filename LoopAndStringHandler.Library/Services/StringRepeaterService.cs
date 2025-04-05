using LoopAndStringHandler.Library.Utilities;

namespace LoopAndStringHandler.Library.Services;

/// <summary>
/// Provides methods to repeat a given text.
/// </summary>
public static class StringRepeaterService
{
    private static readonly InputValidation _inputValidation = new();

    /// <summary>
    /// Repeats the given text ten times.
    /// </summary>
    /// <param name="text">The text to repeat.</param>
    public static void RepeatText(string? text)
    {
        if (_inputValidation.ValidateInput(!string.IsNullOrWhiteSpace(text?.Trim()), "Input cannot be empty. Please try again."))
        {
            string result = "";
            for (int i = 0; i < 10; i++)
            {
                result += $"{i + 1}.{text} ";
            }
            OutputUtil.PrintSuccessMessage(result);
        }
    }
}
