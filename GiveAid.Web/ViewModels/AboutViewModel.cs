namespace GiveAid.Web.ViewModels;

/// <summary>
/// ViewModel representing the comprehensive About Us page.
/// Encapsulates all 7 mandatory sections required by Task 08 and DOC-02 (FR-007 to FR-014).
/// All demo/placeholder information is explicitly labelled.
/// </summary>
public class AboutViewModel
{
    // Section 1: What We Do (FR-007)
    public WhatWeDoSectionViewModel WhatWeDo { get; set; } = new();

    // Section 2: Our Mission & Vision (FR-008)
    public MissionSectionViewModel Mission { get; set; } = new();

    // Section 3: Our Team (FR-009)
    public List<TeamMemberViewModel> TeamMembers { get; set; } = new();

    // Section 4: Career With Us (FR-010)
    public CareerSectionViewModel Career { get; set; } = new();

    // Section 5: Our Achievements (FR-011)
    public List<AchievementMilestoneViewModel> Achievements { get; set; } = new();

    // Section 6: Our Supporters (FR-012)
    public List<SupporterViewModel> Supporters { get; set; } = new();

    // Section 7: Read About Us (FR-013)
    public ReadAboutUsSectionViewModel ReadAboutUs { get; set; } = new();
}

public class WhatWeDoSectionViewModel
{
    public string Headline { get; set; } = "Compassionate Relief & Sustainable Welfare";
    public string Summary { get; set; } = "Give-AID acts as a bridge connecting philanthropic donors, certified local NGOs, and vulnerable communities across Pakistan. We focus on transparent humanitarian intervention, community-driven welfare, and immediate disaster relief.";
    public List<AreaOfWorkItem> FocusAreas { get; set; } = new();
}

public class AreaOfWorkItem
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string IconSvgName { get; set; } = "heart";
}

public class MissionSectionViewModel
{
    public string MissionStatement { get; set; } = "To mobilize humanitarian resources with absolute transparency, empowering disenfranchised families through healthcare, education, clean water, and dignity-first social safety nets.";
    public string VisionStatement { get; set; } = "A socially inclusive and resilient Pakistan where poverty does not prevent access to life-saving medical aid, quality learning, or basic human necessities.";
    public List<string> CoreValues { get; set; } = new();
}

public class TeamMemberViewModel
{
    public string Name { get; set; } = string.Empty;
    public string Role { get; set; } = string.Empty;
    public string Bio { get; set; } = string.Empty;
    public string PlaceholderLabel { get; set; } = "Demonstration Profile";
    public string? AvatarPath { get; set; }
}

public class CareerSectionViewModel
{
    public string Overview { get; set; } = "We are always looking for passionate volunteers, field coordinators, and community advocates dedicated to humanitarian service.";
    public string ApplicationProcess { get; set; } = "Interested applicants and volunteers can register through our Programmes portal or send an expression of interest to our community liaison team.";
    public List<OpenRoleItem> OpenRoles { get; set; } = new();
}

public class OpenRoleItem
{
    public string Title { get; set; } = string.Empty;
    public string Department { get; set; } = string.Empty;
    public string Type { get; set; } = "Volunteer / Field Engagement";
    public string Description { get; set; } = string.Empty;
    public string PlaceholderNotice { get; set; } = "Demonstration Role Placeholder";
}

public class AchievementMilestoneViewModel
{
    public string Year { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Metric { get; set; } = string.Empty;
}

public class SupporterViewModel
{
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty; // Institutional Patron, Academic Partner, Healthcare Partner
    public string ContributionType { get; set; } = string.Empty;
    public string PlaceholderLabel { get; set; } = "Demonstration Supporter";
}

public class ReadAboutUsSectionViewModel
{
    public string InstitutionalHistory { get; set; } = "Founded as an academic initiative under the Software Engineering curriculum, Give-AID models how modern web technology, automated audit trails, and strict role segregation can transform public trust in NGO donation systems.";
    public string GovernanceNarrative { get; set; } = "All simulated donations and programme interests maintain complete auditability through ASP.NET Core Identity and Entity Framework Core, ensuring zero leakage and verifiable reporting.";
    public string AnnualReportNotice { get; set; } = "Audited financial summaries, governance charters, and volunteer impact dossiers are documented and reviewable across each campaign lifecycle.";
}
