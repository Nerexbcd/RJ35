using System.ComponentModel.DataAnnotations;

namespace RJ35.Models.AuthViewModels;

public class LoginViewModel
{
    [Required]
    [EmailAddress]
    public required string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public required string Password { get; set; }

    [Required]
    [Display(Name = "Remember Me")]
    public required bool RememberMe { get; set; }
}