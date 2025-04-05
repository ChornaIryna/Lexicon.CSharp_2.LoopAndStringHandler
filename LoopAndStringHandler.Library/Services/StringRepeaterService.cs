using LoopAndStringHandler.Library.Utilities;

namespace LoopAndStringHandler.Library.Services;

public static class StringRepeaterService
{
    private static readonly InputValidation _inputValidation = new();

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
