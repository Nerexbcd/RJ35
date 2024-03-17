using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RJ35.Models.Products;

public class Device
{
    [Key]
    public required int ProductId { get; set; }
    [ForeignKey("ProductId")]
    public required virtual Product Product { get; set; }
    [Required]
    public required string Model { get; set; }
    [Required]
    public required string DeviceType { get; set; }
}