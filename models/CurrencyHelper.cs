namespace FinanceTracker.Models;

public static class CurrencyHelper
{
    public static string Format(decimal amount, string currencyCode)
    {
        var symbol = currencyCode switch
        {
            "NGN" => "₦",
            "USD" => "$",
            _ => "$"
        };

        return $"{symbol}{amount:N2}";
    }
}