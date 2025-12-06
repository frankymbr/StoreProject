namespace StoreProject.Domain.Entities;

/// <summary>
/// Represents a stock movement for a product (in, out, adjustment).
/// </summary>
public class StockMovement
{
    public int Id { get; set; }
    public int ProductId { get; set; }

    /// <summary>
    /// For example: "In", "Out", "Adjustment".
    /// </summary>
    public string MovementType { get; set; } = null!;
    public decimal Quantity { get; set; }
    public DateTime MovementDate { get; set; }
    public string? Reference { get; set; }
    public string? Comment { get; set; }
    
    //Navigation properties
    public Product Product { get; set; } = null!;

}