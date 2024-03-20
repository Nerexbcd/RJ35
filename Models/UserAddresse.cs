using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RJ35.Models;

public class UserAddresse
{
    [Key]
    public required string UserId { get; set; }
    [ForeignKey("UserId")]
    public required virtual RJ35WebUser User { get; set; }
    [Required]
    public required string Name { get; set; }
    [Required]
    public required string Address { get; set; }
    [Required]
    public required string City { get; set; }
    [Required]
    public required string District { get; set; }
    [Required]
    [RegularExpression(@"^\d{4}(-\d{3})?$")]
    public required string ZipCode { get; set; }
    [Required]
    public required string Country { get; set; }
    [Required]
    [Phone]
    public required string PhoneNumber { get; set; }
    public string? AdditionalInfo { get; set; }
}