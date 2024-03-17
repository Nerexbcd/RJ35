using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RJ35.Models.Products;

public class Cable
{
    [Key]
    public required int ProductId { get; set; }
    [ForeignKey("ProductId")]
    public required virtual Product Product { get; set; }
    [Required]
    public required string Color { get; set; }
    [Required]
    public required string CableType { get; set; }
    [Required]
    public required string Category { get; set; }
    
}