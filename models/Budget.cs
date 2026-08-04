using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinanceTracker.Models;

public class Budget
{
    public int Id { get; set; }

    public int CategoryId { get; set; }
    public Category? Category { get; set; }

    [Range(0.01, 1000000)]
    [Column(TypeName = "decimal(18,2)")]
    public decimal MonthlyLimit { get; set; }

    [Range(1, 12)]
    public int Month { get; set; } = DateTime.Today.Month;

    [Range(2000, 2100)]
    public int Year { get; set; } = DateTime.Today.Year;

    [Required]
    public string UserId { get; set; } = string.Empty;
}