using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using RJ35.Models.Products;


namespace RJ35.Models;

[PrimaryKey(nameof(UserId), nameof(ProductId))]
public class ProductsCart
{
    [Key]
    [Column(Order = 0)]
    public required string UserId { get; set; }
    [ForeignKey("UserId")]
    public required virtual RJ35WebUser User { get; set; }
    [Key]
    [Column(Order = 2)]
    public required int ProductId { get; set; }
    [ForeignKey("ProductId")]
    public required virtual Product Product{ get; set; }
    [Required]
    public required int Quantity { get; set; }
}