using System.ComponentModel.DataAnnotations;

namespace GiveAid.Web.Models;

/// <summary>
/// Represents a community welfare programme, relief camp, or humanitarian event.
/// </summary>
public class Programme
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(150, ErrorMessage = "Programme title cannot exceed 150 characters.")]
    [Display(Name = "Programme Title")]
    public string Title { get; set; } = string.Empty;

    [Required]
    [Display(Name = "Event Objectives & Description")]
    public string Description { get; set; } = string.Empty;

    [Required]
    [Display(Name = "Event Date & Time (UTC)")]
    public DateTime EventDate { get; set; }

    [Required]
    [StringLength(200)]
    [Display(Name = "Venue / City Location")]
    public string Location { get; set; } = string.Empty;

    [StringLength(100)]
    [Display(Name = "Lead Coordinator Name")]
    public string? CoordinatorName { get; set; }

    [StringLength(50)]
    [Display(Name = "Coordinator Contact")]
    public string? CoordinatorContact { get; set; }

    [StringLength(250)]
    [Display(Name = "Event Banner Image Path")]
    public string? BannerImagePath { get; set; }

    [Required]
    [StringLength(25)]
    [Display(Name = "Programme Status")]
    public string Status { get; set; } = "Scheduled"; // Scheduled, Completed, Cancelled

    [Display(Name = "Created Date (UTC)")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Navigation properties
    public ICollection<ProgrammeInterest> Interests { get; set; } = new List<ProgrammeInterest>();
    public ICollection<GalleryImage> GalleryImages { get; set; } = new List<GalleryImage>();
}
