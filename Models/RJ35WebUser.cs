using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace RJ35.Models;

public class RJ35WebUser : IdentityUser
{
    [Required]
    public string ProfileImg { get; set; } = "/images/Users/default.png";

    // [Required]
    // [MaxLength(100)]
    // public string FirstName { get; set; } = string.Empty;

    // [Required]
    // [MaxLength(100)]
    // public string LastName { get; set; } = string.Empty;
}

