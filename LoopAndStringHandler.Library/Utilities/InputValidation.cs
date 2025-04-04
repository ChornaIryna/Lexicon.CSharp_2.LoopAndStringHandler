namespace LoopAndStringHandler.Library.Utilities;

public class InputValidation
{
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
