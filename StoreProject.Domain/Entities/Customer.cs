namespace StoreProject.Domain.Entities;

/// <summary>
/// Represents a customer that can place orders.
/// </summary>
public class Customer
{
    public int Id { get; set; }
    public string FullName { get; set; } = null!;
    public string? DocumentNumber { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string? Address { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreatedAt { get; set; }
    
    //Navigation properties
    public ICollection<Order> Orders { get; set; } = new List<Order>();
}