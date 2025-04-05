# C# Exercise - Flow via Loops and String Manipulation

### Overview
This project is a C# console application that demonstrates the use of loops and string manipulation. The application provides a main menu with various options for the user to interact with, including checking ticket prices by age, calculating total prices for a group, repeating text, and extracting the third word from a sentence.

### Main Menu
The main menu is the entry point of the application, guiding the user through different functionalities. The menu is displayed using the MenuService class, which provides methods to display and run menu options.

### Menu Options
1. **Check Ticket Price by Age**: This option allows the user to input their age and receive the corresponding ticket price based on predefined age categories.
    - The user enters their age.
    - The program converts the age from a string to an integer.
    - The program checks if the person is a youth (under 20 years) or a senior (over 64 years) and displays the corresponding ticket price.
    - If the person is neither a youth nor a senior, the standard price is displayed.
2. **Calculate Total Price for a Group**: This option allows the user to input the number of adults and children in a group and calculates the total ticket price based on predefined prices.
    - The user enters the number of people in the group.
    - The program asks for the age of each person in the group.
    - The program calculates the total price for the group based on the ages provided and displays the total cost.
3. **Repeat Text Ten Times**: This option allows the user to input a text string and repeats it ten times.
    - The user enters a text string.
    - The program repeats the entered text ten times using a for-loop and displays the repeated text.
4. **Extract the Third Word**: This option allows the user to input a sentence and extracts the third word from it.
    - The user enters a sentence with at least three words.
    - The program splits the sentence into words and checks if there are at least three words.
    - If there are three or more words, the program displays the third word; otherwise, it informs the user that there are not enough words.
0. **Quit**: This option exits the application.

### Code Structure
- MenuService.cs: Provides methods to display and run menu options.
- TicketPricingService.cs: Provides methods to calculate ticket prices based on age categories.
- StringRepeaterService.cs: Provides methods to repeat a given text.
- WordExtractorService.cs: Provides methods to extract words from a sentence.
- InputValidation.cs: Provides methods for input validation.
- OutputUtil.cs: Provides methods to print messages to the console with specific colors.

### Additional Features
- Input validation to ensure the program handles invalid inputs gracefully.
- Customizable ticket prices for different age categories.
- Clear and user-friendly console output with color-coded messages.

### Extra Tasks
For those who have extra time, consider implementing the following:
1.	Validate all inputs from the user to ensure the program does not crash on invalid input.
2.	Provide free entry for children under 5 years and seniors over 100 years.
3.	Handle multiple spaces in the input sentence for the word extractor.
4.	Explore additional interesting features to add or practice with the application.
