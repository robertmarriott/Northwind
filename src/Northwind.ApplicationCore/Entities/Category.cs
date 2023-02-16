namespace Northwind.ApplicationCore.Entities;

public class Category
{
    public int CategoryId { get; set; }
    public required string CategoryName { get; set; }
    public string? Description { get; set; }
    public byte[]? Picture { get; set; }
    public ICollection<Product> Products { get; } = new List<Product>();
}
