using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GiveAid.Web.Models;

/// <summary>
/// Represents a charitable fundraising campaign or relief cause.
/// </summary>
public class Cause
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(150, ErrorMessage = "Title cannot exceed 150 characters.")]
    [Display(Name = "Cause Title")]
    public string Title { get; set; } = string.Empty;

    [Required]
    [StringLength(300, ErrorMessage = "Short description cannot exceed 300 characters.")]
    [Display(Name = "Summary")]
    public string ShortDescription { get; set; } = string.Empty;

    [Required]
    [Display(Name = "Detailed Narrative")]
    public string FullDescription { get; set; } = string.Empty;

    [Required]
    [Range(1, 100000000, ErrorMessage = "Target amount must be at least 1.")]
    [Column(TypeName = "decimal(18,2)")]
    [Display(Name = "Fundraising Target Amount")]
    public decimal TargetAmount { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    [Display(Name = "Current Amount Raised")]
    public decimal CurrentAmount { get; set; } = 0.00m;

    [StringLength(250)]
    [Display(Name = "Campaign Image Path")]
    public string? ImagePath { get; set; }

    [Display(Name = "Featured on Home Page")]
    public bool IsFeatured { get; set; } = false;

    [Display(Name = "Active Status")]
    public bool IsActive { get; set; } = true;

    [Display(Name = "Campaign Start Date (UTC)")]
    public DateTime? StartDate { get; set; }

    [Display(Name = "Campaign End Date (UTC)")]
    public DateTime? EndDate { get; set; }

    [Display(Name = "Created Date (UTC)")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Foreign key to organizing NGO
    [Required]
    [Display(Name = "Organizing NGO")]
    public int NgoId { get; set; }

    [ForeignKey("NgoId")]
    public NGO? Ngo { get; set; }

    // Navigation property: One cause receives multiple donation records
    public ICollection<Donation> Donations { get; set; } = new List<Donation>();
}
