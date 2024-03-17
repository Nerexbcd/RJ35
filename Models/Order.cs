using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RJ35.Models;

public class Order
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int OrderID { get; set; }
    [Required]
    public DateTime OrderDate { get; set; } = DateTime.Now;
    [Required]
    public required string UserId { get; set; }
    [ForeignKey("UserId")]
    public required virtual RJ35WebUser User { get; set; }
    [Required]
    public required decimal OrderTotal { get; set; }
    [Required]
    public required OrderStatus OrderStatus { get; set; }
}

public enum OrderStatus
{
    Pending,
    Shipped,
    Delivered,
    Canceled
}