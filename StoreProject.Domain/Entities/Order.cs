namespace StoreProject.Domain.Entities;

/// <summary>
/// Represents a sales order / ticket.
/// </summary>
public class Order
{
    public int Id { get; set; }
    public string OrderNumber { get; set; } = null!;
    /// <summary>
    /// Nullable: quick sale without a customer record.
    /// </summary>
    public int? CustomerId { get; set; }
    public DateTime OrderDate { get; set; }
    /// <summary>
    /// For example: "Pending", "Paid", "Cancelled".
    /// </summary>
    public string Status { get; set; } = null!;
    public decimal Total { get; set; }

    /// <summary>
    /// For example: "Cash", "Card", "Transfer".
    /// </summary>
    public string PaymentMethod { get; set; } = null!;
    public string? Notes { get; set; }
    
    //Navigation properties
    public Customer? Customer { get; set; }
    public ICollection<OrderItem>? Items { get; set; } = new List<OrderItem>();



}