using LoopAndStringHandler.Library.Services;
using LoopAndStringHandler.Library.Utilities;

namespace LoopAndStringHandler;

/// <summary>
/// Provides the user interface for interacting with the application.
/// </summary>
internal class UserInterface
{
    private bool _running = true;
    private readonly MenuService _menuService = new();
    private readonly InputValidation _inputValidation = new();

    /// <summary>
    /// Runs the main loop of the user interface.
    /// </summary>
    internal void Run()
    {
        while (_running)
        {
            _menuService.DisplayMenu();
            string? choice = Console.ReadLine()?.Trim();

            ProcessChoice(choice);

            Console.WriteLine();
        }
    }

    /// <summary>
    /// Processes the user's menu choice.
    /// </summary>
    /// <param name="choice">The user's menu choice.</param>
    private void ProcessChoice(string? choice)
    {
        if (_inputValidation.ValidateInput(uint.TryParse(choice, out uint result)))
            _menuService.RunMenuOption(result);
        if (choice == "0")
            _running = false;
    }
}