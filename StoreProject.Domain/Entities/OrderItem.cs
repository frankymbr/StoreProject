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
    public decimal UnitPrice { get; set; }
    public decimal Discount { get; set; }
    public decimal SubTotal { get; set; }
    
    //Navigation properties
    public Order Order { get; set; } = null!;
    public Product Product { get; set; } = null!;
}