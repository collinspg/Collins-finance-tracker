using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinanceTracker.Models;

public enum TransactionType
{
    Income,
    Expense
}

public class Transaction
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Description { get; set; } = string.Empty;

    [Range(0.01, 1000000)]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Amount { get; set; }

    [Required]
    public DateTime Date { get; set; } = DateTime.Today;

    [Required]
    public TransactionType Type { get; set; }

    public int CategoryId { get; set; }
    public Category? Category { get; set; }

    [Required]
    public string UserId { get; set; } = string.Empty;
}