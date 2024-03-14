using System.ComponentModel.DataAnnotations;

namespace RJ35.Models.AuthViewModels;

public class ForgotPasswordViewModel
{
    [Required]
    [EmailAddress]
    public required string Email { get; set; }

}