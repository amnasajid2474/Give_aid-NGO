using System.ComponentModel.DataAnnotations;

namespace GiveAid.Web.Models;

/// <summary>
/// Represents a corporate partner, sponsor, or supporting community institution.
/// </summary>
public class Partner
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(150, ErrorMessage = "Partner Name cannot exceed 150 characters.")]
    [Display(Name = "Partner Name")]
    public string Name { get; set; } = string.Empty;

    [StringLength(50)]
    [Display(Name = "Partnership Type")]
    public string PartnerType { get; set; } = "Corporate Sponsor";

    [StringLength(500)]
    [Display(Name = "Partner Synopsis")]
    public string? Description { get; set; }

    [Url]
    [StringLength(250)]
    [Display(Name = "Website URL")]
    public string? WebsiteUrl { get; set; }

    [StringLength(250)]
    [Display(Name = "Logo Image Path")]
    public string? LogoPath { get; set; }

    [Display(Name = "Display Order")]
    public int DisplayOrder { get; set; } = 0;

    [Display(Name = "Active Status")]
    public bool IsActive { get; set; } = true;

    [Display(Name = "Created Date (UTC)")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
