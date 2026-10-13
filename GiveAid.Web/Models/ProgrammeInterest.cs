using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GiveAid.Web.Models;

/// <summary>
/// Represents an application or expression of interest to participate or volunteer in an upcoming programme.
/// </summary>
public class ProgrammeInterest
{
    [Key]
    public int Id { get; set; }

    [Required]
    [Display(Name = "Welfare Programme")]
    public int ProgrammeId { get; set; }

    [ForeignKey("ProgrammeId")]
    public Programme? Programme { get; set; }

    [StringLength(450)]
    [Display(Name = "Registered User ID")]
    public string? UserId { get; set; }

    [Required]
    [StringLength(100, ErrorMessage = "Applicant name cannot exceed 100 characters.")]
    [Display(Name = "Applicant Full Name")]
    public string ApplicantName { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    [StringLength(100)]
    [Display(Name = "Applicant Email Address")]
    public string ApplicantEmail { get; set; } = string.Empty;

    [Required]
    [Phone]
    [StringLength(30)]
    [Display(Name = "Contact Telephone")]
    public string ApplicantPhone { get; set; } = string.Empty;

    [StringLength(500)]
    [Display(Name = "Volunteer Skills or Notes")]
    public string? VolunteerNote { get; set; }

    [Required]
    [StringLength(25)]
    [Display(Name = "Application Status")]
    public string Status { get; set; } = "Submitted"; // Submitted, Approved, Declined, Attended

    [Display(Name = "Submission Date (UTC)")]
    public DateTime SubmissionDate { get; set; } = DateTime.UtcNow;
}
