using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RJ35.Models;

public class UserNotifications
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    [ForeignKey("UserId")]
    public required string UserId { get; set; }
    public required virtual RJ35WebUser User { get; set; }
    [Required]
    public required string Content { get; set; }
    public bool IsRead { get; set; } = false;
}