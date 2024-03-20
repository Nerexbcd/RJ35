using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RJ35.Models.Products;

public class ProductReview
{
    [Key]
    public required int ProductId { get; set; }
    [ForeignKey("ProductId")]
    public required virtual Product Product { get; set; }
    [Required]
    public required string UserId { get; set; }
    [ForeignKey("UserId")]
    public required virtual RJ35WebUser User { get; set; }
    [Required]
    public required int Rating { get; set; }
    [Required]
    public required string Comment { get; set; }
    
    [Required]
    public required DateTime Date { get; set; }
    
}