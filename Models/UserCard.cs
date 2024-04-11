using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RJ35.Models;

public class UserCard
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CardID { get; set; }
    [Required]
    public required string UserId { get; set; }
    [ForeignKey("UserId")]
    public required virtual RJ35WebUser User { get; set; }
    [Required]
    public required string Name { get; set; }
    [Required]
    [StringLength(16)]
    public required string Number { get; set; }
    [Required]
    [StringLength(3)]
    public required string Code { get; set; }
    [Required]
    [DataType(DataType.Date)]
    public required DateTime Expire { get; set; }
}