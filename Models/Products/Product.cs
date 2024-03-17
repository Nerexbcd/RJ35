using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RJ35.Models.Products;

public class Product
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ProductId { get; set; }
    [Required]
    public required string Name { get; set; }
    [Required]
    public required string Brand { get; set; }
    public string? Description { get; set; }
    [Required]
    public required int Stock { get; set; } = 0;
    [Required]
    public required decimal Price { get; set; }
    [Required]
    public required string Image { get; set; }
    [Required]
    public required ProductCategory ProductCategory { get; set; }
    public DateTime CreatedAt { get; set; }
}

public enum ProductCategory
{
    Cable,
    Rack,
    Device
}