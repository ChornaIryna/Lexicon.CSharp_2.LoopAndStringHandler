using LoopAndStringHandler.Library.Services;
using LoopAndStringHandler.Library.Utilities;

namespace LoopAndStringHandler;

internal class UserInterface
{
    private bool _running = true;
    private readonly MenuService _menuService = new();
    private readonly InputValidation _inputValidation = new();
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

    private void ProcessChoice(string? choice)
    {
        if (_inputValidation.ValidateInput(uint.TryParse(choice, out uint result)))
            _menuService.RunMenuOption(result);
        if (choice == "0")
            _running = false;
    }
}