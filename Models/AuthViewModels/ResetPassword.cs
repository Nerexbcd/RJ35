using System.ComponentModel.DataAnnotations;

namespace RJ35.Models.AuthViewModels;

public class ResetPasswordViewModel
{
    [Required]
    [EmailAddress]
    public required string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public required string Password { get; set; }

    [Required]
    public required string Code { get; set; }
}