namespace LoopAndStringHandler.Library.Utilities;
/// <summary>
/// Provides methods for input validation.
/// </summary>
public class InputValidation
{
    /// <summary>
    /// Validates the input based on the specified condition.
    /// </summary>
    /// <param name="valid">A boolean indicating whether the input is valid.</param>
    /// <param name="errorMessage">The error message to display if the input is invalid.</param>
    /// <returns>True if the input is valid; otherwise, false.</returns>
    public bool ValidateInput(bool valid, string errorMessage = "Input is outside the acceptable range.")
    {
        if (!valid)
        {
            OutputUtil.PrintErrorMessage($"Invalid input detected. {errorMessage}");
            return false;
        }
        else
            return true;
    }

}
