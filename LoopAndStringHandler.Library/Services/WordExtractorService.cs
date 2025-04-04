using LoopAndStringHandler.Library.Utilities;

namespace LoopAndStringHandler.Library.Services;

public static class WordExtractorService
{
    private static readonly InputValidation _inputValidation = new();
    /// <summary>
    /// Extracts the third word from a sentence.
    /// </summary>
    /// <param name="sentence">The sentence to extract the word from.</param>
    /// <returns>The third word, or an error message if not applicable.</returns>
    public static void GetThirdWord(string sentence)
    {
        string[] words = sentence.Split([' '], StringSplitOptions.RemoveEmptyEntries);
        if (_inputValidation.ValidateInput(words.Length >= 3, "The sentence does not contain at least three words. Please try again."))
            OutputUtil.PrintSuccessMessage(words[2]);
    }
}
