using System.ComponentModel.DataAnnotations;

namespace GiveAid.Web.Models;

/// <summary>
/// Represents an accredited non-governmental organization affiliated with the Give-AID platform.
/// </summary>
public class NGO
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(150, ErrorMessage = "NGO Name cannot exceed 150 characters.")]
    [Display(Name = "NGO Name")]
    public string Name { get; set; } = string.Empty;

    [StringLength(50)]
    [Display(Name = "Registration Number")]
    public string? RegistrationNumber { get; set; }

    [StringLength(1000)]
    [Display(Name = "Mission & Description")]
    public string? Description { get; set; }

    [StringLength(250)]
    public string? Address { get; set; }

    [EmailAddress]
    [StringLength(100)]
    public string? Email { get; set; }

    [Phone]
    [StringLength(30)]
    public string? Phone { get; set; }

    [Url]
    [StringLength(250)]
    [Display(Name = "Website URL")]
    public string? WebsiteUrl { get; set; }

    [StringLength(250)]
    [Display(Name = "Logo Image Path")]
    public string? LogoPath { get; set; }

    [Display(Name = "Active Status")]
    public bool IsActive { get; set; } = true;

    [Display(Name = "Created Date (UTC)")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Navigation property: One NGO manages multiple charitable causes
    public ICollection<Cause> Causes { get; set; } = new List<Cause>();
}
