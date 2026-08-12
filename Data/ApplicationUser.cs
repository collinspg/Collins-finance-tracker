using Microsoft.AspNetCore.Identity;
namespace FinanceTracker.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    public string PreferredCurrency { get; set; } = "USD";
}