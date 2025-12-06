namespace StoreProject.Domain.Entities;

/// <summary>
/// Represents a single line inside an order (product + quantity).
/// </summary>
public class OrderItem
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public decimal Quantity { get; set; }
    /// <summary>
    /// Unit price before discount.
    /// </summary>
    public decimal UnitPrice { get; set; }
    /// <summary>
    /// Discount amount applied to this line (total, not per unit).
    /// For example: 1.50 means 1.50 off this line.
    /// </summary>
    public decimal Discount { get; set; }
    /// <summary>
    /// Line subtotal after discount.
    /// </summary>
    public decimal SubTotal { get; set; }
    
    //Navigation properties
    public Order Order { get; set; } = null!;
    public Product Product { get; set; } = null!;
}