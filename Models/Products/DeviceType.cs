using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RJ35.Models.Products;

public class DeviceType
{
    [Key]
    public required int TypeId { get; set; }
    [Required]
    public required string Name { get; set; }
}