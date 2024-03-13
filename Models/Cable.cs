using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RJ35.Models;

public class Cable
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    public required string Brand { get; set; }
    public string? Description { get; set; }
    [Required]
    public required string CableType { get; set; }
    [Required]
    public required string Category { get; set; }
    public decimal MetersAvaliable { get; set; }
    [Required]
    public required decimal PriceMeter { get; set; }
    [Required]
    public required string Image { get; set; }
    
}