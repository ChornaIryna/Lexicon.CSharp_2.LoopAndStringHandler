using LoopAndStringHandler.Library.Utilities;

namespace LoopAndStringHandler.Library.Services;

/// <summary>
/// Provides methods to extract words from a sentence.
/// </summary>
public static class WordExtractorService
{
    private static readonly InputValidation _inputValidation = new();

    /// <summary>
    /// Gets the third word from a sentence.
    /// </summary>
    /// <param name="sentence">The sentence from which to extract the third word.</param>
    public static void GetThirdWord(string sentence)
    {
        string[] words = sentence.Split([' '], StringSplitOptions.RemoveEmptyEntries);
        if (_inputValidation.ValidateInput(words.Length >= 3, "The sentence does not contain at least three words. Please try again."))
            OutputUtil.PrintSuccessMessage(words[2]);
    }
}
