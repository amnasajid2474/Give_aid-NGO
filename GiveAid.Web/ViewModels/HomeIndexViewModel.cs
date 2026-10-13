namespace GiveAid.Web.ViewModels;

/// <summary>
/// ViewModel representing public Home page content, featured campaigns,
/// upcoming welfare programmes, impact statistics, and partner network.
/// </summary>
public class HomeIndexViewModel
{
    public List<HomeCauseCardViewModel> FeaturedCauses { get; set; } = new();
    public List<HomeProgrammeCardViewModel> UpcomingProgrammes { get; set; } = new();
    public List<HomePartnerCardViewModel> Partners { get; set; } = new();

    // Impact Statistics (Demonstration baseline or live database metrics)
    public decimal TotalFundsRaised { get; set; }
    public int LivesTouched { get; set; }
    public int CompletedProjects { get; set; }
    public int RegisteredVolunteers { get; set; }
    public int ActivePartnerNgos { get; set; }
    public bool IsDemoImpactData { get; set; } = true;
}

public class HomeCauseCardViewModel
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string ShortDescription { get; set; } = string.Empty;
    public decimal TargetAmount { get; set; }
    public decimal CurrentAmount { get; set; }
    public int ProgressPercentage => TargetAmount > 0 ? (int)Math.Min(100, Math.Round((CurrentAmount / TargetAmount) * 100)) : 0;
    public string? ImagePath { get; set; }
    public string NgoName { get; set; } = "Give-AID Partner NGO";
    public bool IsDemo { get; set; } = false;
}

public class HomeProgrammeCardViewModel
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime EventDate { get; set; }
    public string Location { get; set; } = string.Empty;
    public string? BannerImagePath { get; set; }
    public string Status { get; set; } = "Scheduled";
    public bool IsDemo { get; set; } = false;
}

public class HomePartnerCardViewModel
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string PartnerType { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string? LogoPath { get; set; }
    public string? WebsiteUrl { get; set; }
    public bool IsDemo { get; set; } = false;
}
