using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace GiveAid.Web.Models;

/// <summary>
/// Extended ASP.NET Core Identity user for Give-AID.
/// Adds FullName and CreatedAt fields to the standard IdentityUser.
/// </summary>
public class ApplicationUser : IdentityUser
{
    /// <summary>Full display name of the registered user.</summary>
    [Required]
    [StringLength(100, ErrorMessage = "Full name cannot exceed 100 characters.")]
    [Display(Name = "Full Name")]
    public string FullName { get; set; } = string.Empty;

    /// <summary>UTC timestamp when the account was created.</summary>
    [Display(Name = "Registered On")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
