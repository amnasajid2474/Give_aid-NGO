using System.ComponentModel.DataAnnotations;

namespace GiveAid.Web.Models;

/// <summary>
/// Records friend referral invitations sent by registered members to spread awareness.
/// </summary>
public class Invitation
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(450)]
    [Display(Name = "Sender User ID")]
    public string SenderUserId { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    [StringLength(100)]
    [Display(Name = "Recipient Email Address")]
    public string RecipientEmail { get; set; } = string.Empty;

    [StringLength(500)]
    [Display(Name = "Personalized Invitation Message")]
    public string? InviteMessage { get; set; }

    [Display(Name = "Sent Date (UTC)")]
    public DateTime SentAt { get; set; } = DateTime.UtcNow;

    [Required]
    [StringLength(25)]
    [Display(Name = "Delivery Status")]
    public string DeliveryStatus { get; set; } = "Logged"; // Logged, Sent, Failed
}
