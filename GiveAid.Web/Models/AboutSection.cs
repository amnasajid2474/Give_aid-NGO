using System.ComponentModel.DataAnnotations;

namespace GiveAid.Web.Models;

/// <summary>
/// Represents manageable content sections for the 7 About Us page areas.
/// Supports FR-014 (Admin content manageability).
/// </summary>
public class AboutSection
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    [Display(Name = "Section Identifier Key")]
    public string SectionKey { get; set; } = string.Empty; // WhatWeDo, Mission, Team, Careers, Achievements, Supporters, ReadAboutUs

    [Required]
    [StringLength(150)]
    [Display(Name = "Section Heading")]
    public string Title { get; set; } = string.Empty;

    [Required]
    [Display(Name = "Section Narrative Content")]
    public string Content { get; set; } = string.Empty;

    [StringLength(250)]
    [Display(Name = "Optional Image Asset Path")]
    public string? ImagePath { get; set; }

    [Display(Name = "Display Order")]
    public int DisplayOrder { get; set; } = 0;

    [Display(Name = "Active Status")]
    public bool IsActive { get; set; } = true;

    [Display(Name = "Last Modified Date (UTC)")]
    public DateTime LastModifiedAt { get; set; } = DateTime.UtcNow;
}
