using LoopAndStringHandler.Library.Utilities;

namespace LoopAndStringHandler.Library.Services;

public static class WordExtractorService
{
    private static readonly InputValidation _inputValidation = new();
   
    public static void GetThirdWord(string sentence)
    {
        string[] words = sentence.Split([' '], StringSplitOptions.RemoveEmptyEntries);
        if (_inputValidation.ValidateInput(words.Length >= 3, "The sentence does not contain at least three words. Please try again."))
            OutputUtil.PrintSuccessMessage(words[2]);
    }
}
