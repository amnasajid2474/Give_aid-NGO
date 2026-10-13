using System.ComponentModel.DataAnnotations;

namespace GiveAid.Web.Models;

/// <summary>
/// Represents a visitor or member inquiry submitted through the Contact Us form.
/// </summary>
public class ContactQuery
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(100, ErrorMessage = "Sender name cannot exceed 100 characters.")]
    [Display(Name = "Sender Full Name")]
    public string SenderName { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    [StringLength(100)]
    [Display(Name = "Sender Email Address")]
    public string SenderEmail { get; set; } = string.Empty;

    [Phone]
    [StringLength(30)]
    [Display(Name = "Sender Phone Number")]
    public string? SenderPhone { get; set; }

    [Required]
    [StringLength(150, ErrorMessage = "Subject cannot exceed 150 characters.")]
    [Display(Name = "Subject")]
    public string Subject { get; set; } = string.Empty;

    [Required]
    [StringLength(2000, ErrorMessage = "Message cannot exceed 2000 characters.")]
    [Display(Name = "Message")]
    public string Message { get; set; } = string.Empty;

    [Display(Name = "Submitted Timestamp (UTC)")]
    public DateTime SubmittedAt { get; set; } = DateTime.UtcNow;

    [Required]
    [StringLength(25)]
    [Display(Name = "Resolution Status")]
    public string Status { get; set; } = "New"; // New, Reviewed, Replied, Closed

    [StringLength(1000)]
    [Display(Name = "Internal Administrator Notes")]
    public string? AdminNotes { get; set; }

    // Optional link if inquiry was submitted by a logged-in member
    [StringLength(450)]
    [Display(Name = "Registered User ID")]
    public string? UserId { get; set; }
}
