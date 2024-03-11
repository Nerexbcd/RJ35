using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RJ35.Models;

public class Cable
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    public string? Brand { get; set; }
    public string? Description { get; set; }
    [Required]
    public string? CableType { get; set; }
    [Required]
    public string? Category { get; set; }
    public decimal MetersAvaliable { get; set; }
    [Required]
    public decimal PriceMeter { get; set; }
    [Required]
    public string? Image { get; set; }
    
}