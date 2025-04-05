using LoopAndStringHandler.Library.Utilities;

namespace LoopAndStringHandler.Library.Services
{
    /// <summary>
    /// Provides methods to display and run menu options.
    /// </summary>
    public class MenuService
    {
        private readonly InputValidation _inputValidation = new();

        /// <summary>
        /// Displays the main menu to the console.
        /// </summary>
        public void DisplayMenu()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("-- Welcome to the Main Menu! --");
            Console.ResetColor();
            Console.WriteLine("Please enter a number to select an option:");
            Console.WriteLine("1. Check ticket price by age");
            Console.WriteLine("2. Calculate total price for a group");
            Console.WriteLine("3. Repeat text ten times");
            Console.WriteLine("4. Extract the third word");
            Console.WriteLine("0. Quit");
        }

        /// <summary>
        /// Runs the selected menu option.
        /// </summary>
        /// <param name="option">The menu option selected by the user.</param>
        public void RunMenuOption(uint option)
        {
            switch (option)
            {
                case 1:
                    RunTicketPriceCategoryCheck();
                    break;
                case 2:
                    RunGroupTicketPriceCalculator();
                    break;
                case 3:
                    RunStringRepeater();
                    break;
                case 4:
                    RunWordExtractor();
                    break;
                case 0:
                    OutputUtil.PrintSuccessMessage("Goodbye for now! Take care and stay awesome!");
                    break;
                default:
                    OutputUtil.PrintErrorMessage("Invalid option. Please try again.");
                    break;
            }
        }

        /// <summary>
        /// Runs the ticket price category check.
        /// </summary>
        private void RunTicketPriceCategoryCheck()
        {
            Console.Write("Enter your age: ");
            TicketPricingService.GetTicketPrice(Console.ReadLine()?.Trim());
        }

        /// <summary>
        /// Runs the group ticket price calculator.
        /// </summary>
        private void RunGroupTicketPriceCalculator()
        {
            Console.Write("Enter the number of people in the group: ");
            if (_inputValidation.ValidateInput(uint.TryParse(Console.ReadLine()?.Trim(), out uint numberOfPeople) && numberOfPeople > 0,
                                               "Please enter a valid number of people (a number greater than 0)."))
            {
                uint[] ages = new uint[numberOfPeople];
                for (int i = 0; i < numberOfPeople; i++)
                {
                    int personNumber = i + 1;
                    uint age;
                    do
                    {
                        Console.Write($"Enter the age of person {personNumber}: ");
                    }
                    while (!_inputValidation.ValidateInput(uint.TryParse(Console.ReadLine()?.Trim(), out age), "Please enter a valid age (a number greater than 0)."));
                    ages[i] = age;
                }
                TicketPricingService.GetGroupTicketPrice(ages);
            }
        }

        /// <summary>
        /// Runs the string repeater.
        /// </summary>
        private void RunStringRepeater()
        {
            Console.Write("Enter a text to repeat: ");
            StringRepeaterService.RepeatText(Console.ReadLine());
        }

        /// <summary>
        /// Runs the word extractor.
        /// </summary>
        private void RunWordExtractor()
        {
            Console.Write("Enter a sentence with at least three words: ");
            string? sentence = Console.ReadLine()?.Trim();
            if (sentence != null)
                WordExtractorService.GetThirdWord(sentence);
        }
    }
}
