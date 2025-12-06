namespace StoreProject.Domain.Entities;

/// <summary>
/// Represents a product category (e.g. Beverages, Tools, Groceries).
/// </summary>
public class Category
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;
    public string? Description { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    // Navigation properties
    public ICollection<Product> Products { get; set; } = new List<Product>();
}