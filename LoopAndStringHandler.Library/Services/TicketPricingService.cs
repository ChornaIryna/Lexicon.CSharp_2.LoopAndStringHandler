using LoopAndStringHandler.Library.Utilities;

namespace LoopAndStringHandler.Library.Services;

/// <summary>
/// Provides methods to calculate ticket prices based on age categories.
/// </summary>
public static class TicketPricingService
{
    private static readonly InputValidation _inputValidation = new();
    private static readonly Dictionary<PriceCategory, decimal> _ticketPrices = new Dictionary<PriceCategory, decimal>(){
            { PriceCategory.Youth, 80.0m },
            { PriceCategory.Senior, 90.0m },
            { PriceCategory.Standard, 120.0m },
            { PriceCategory.Group, 0.0m }
        };

    /// <summary>
    /// Gets the ticket price based on the age.
    /// </summary>
    /// <param name="age">The age of the person.</param>
    public static void GetTicketPrice(string? age)
    {
        if (_inputValidation.ValidateInput(uint.TryParse(age, out uint parsedAge), "Please enter a valid age (a number greater than 0)."))
        {
            OutputUtil.PrintSuccessMessage(GetTicketPrice(parsedAge));
        }
    }

    /// <summary>
    /// Gets the total ticket price for a group based on their ages.
    /// </summary>
    /// <param name="ages">The ages of the group members.</param>
    public static void GetGroupTicketPrice(uint[] ages)
    {
        CalculateGroupPrice(ages);
        OutputUtil.PrintSuccessMessage($"Number of people in the group: {ages.Length}");
        OutputUtil.PrintSuccessMessage(GetStringMessage(PriceCategory.Group));
    }

    /// <summary>
    /// Calculates the total ticket price for a group based on their ages.
    /// </summary>
    /// <param name="ages">The ages of the group members.</param>
    private static void CalculateGroupPrice(uint[] ages)
    {
        decimal totalPrice = 0.0m;
        foreach (uint age in ages)
        {
            if (age >= 5 && age <= 19)
                totalPrice += GetPriceByCategory(PriceCategory.Youth);
            else if (age >= 20 && age <= 64)
                totalPrice += GetPriceByCategory(PriceCategory.Standard);
            else if (age >= 65 && age <= 99)
                totalPrice += GetPriceByCategory(PriceCategory.Senior);
        }
        _ticketPrices[PriceCategory.Group] = totalPrice;
    }

    /// <summary>
    /// Gets the ticket price based on the age.
    /// </summary>
    /// <param name="age">The age of the person.</param>
    /// <returns>The ticket price as a string.</returns>
    private static string GetTicketPrice(uint age)
    {
        if (age < 5 || age >= 100)
            return "Free entry.";
        else if (age < 20)
            return GetStringMessage(PriceCategory.Youth);
        else if (age > 64)
            return GetStringMessage(PriceCategory.Senior);
        else
            return GetStringMessage(PriceCategory.Standard);
    }

    /// <summary>
    /// Gets the price for a specific category.
    /// </summary>
    /// <param name="priceCategory">The price category.</param>
    /// <returns>The price for the category.</returns>
    private static decimal GetPriceByCategory(PriceCategory priceCategory)
    {
        return _ticketPrices.FirstOrDefault(ticket => ticket.Key.Equals(priceCategory)).Value;
    }

    /// <summary>
    /// Gets the price message for a specific category.
    /// </summary>
    /// <param name="priceCategory">The price category.</param>
    /// <returns>The price message for the category.</returns>
    private static string GetStringMessage(PriceCategory priceCategory)
    {
        return $"{priceCategory} price: {GetPriceByCategory(priceCategory):C}";
    }
}
