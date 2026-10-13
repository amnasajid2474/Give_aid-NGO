using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GiveAid.Web.Controllers;

/// <summary>
/// Controller for administrative functions.
/// Access is strictly protected by the "Admin" role.
/// Non-admin users are automatically redirected to AccessDenied.
/// </summary>
[Authorize(Roles = "Admin")]
public class AdminController : Controller
{
    private readonly ILogger<AdminController> _logger;

    public AdminController(ILogger<AdminController> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// Admin Dashboard landing test page.
    /// Confirms role-based access authorization for Task 7.
    /// </summary>
    [HttpGet]
    public IActionResult Index()
    {
        _logger.LogInformation("Admin dashboard accessed by {User}", User.Identity?.Name);
        return View();
    }
}
