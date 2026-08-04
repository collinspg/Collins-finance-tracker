using System.ComponentModel.DataAnnotations;

namespace FinanceTracker.Models;

public class Category
{
    public int Id { get; set; }

    [Required]
    [StringLength(50, MinimumLength = 1)]
    public string Name { get; set; } = string.Empty;

    // Ties this category to the logged-in user
    [Required]
    public string UserId { get; set; } = string.Empty;
}