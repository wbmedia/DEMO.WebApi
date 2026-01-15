namespace DEMO.WebApi.Models;

public class ProductModel
{
    public required string Name { get; set; } = string.Empty;
    public required string Description { get; set; } = string.Empty;
    public required int Stock { get; set; }
    public required decimal Price { get; set; }
    public required DateTime CreatedAt { get; set; }
}
