# Task 7 — Authentication and Roles (ASP.NET Core Identity)

**Project:** Give-AID — NGO Management & Donation Website  
**Task Number:** 7  
**Status:** ✅ Completed  
**Completed On:** 2026-10-13

---

## 1. Overview

Task 7 implements a secure, extensible authentication and authorization subsystem for Give-AID using **ASP.NET Core Identity** integrated directly into the existing `ApplicationDbContext` and SQL Server database (`GiveAidDb`).

The implementation establishes:
- Custom user entity `ApplicationUser` extending `IdentityUser` with `FullName` and `CreatedAt`
- Role-based access control (RBAC) supporting `Admin` and `User` roles
- Idempotent startup role seeding service (`RoleSeedService`)
- Secure registration and login workflows with password complexity, lockout protection, and return URL validation
- Full protection of administrative routes (`[Authorize(Roles = "Admin")]`)
- Interactive navbar integration with dynamic authentication state display
- Zero hardcoded passwords (credentials sourced via User Secrets / environment configuration)

---

## 2. Technology & Dependencies

| Component | Version | Notes |
|---|---|---|
| .NET SDK | 10.0.401 | Target framework `net10.0` |
| `Microsoft.AspNetCore.Identity.EntityFrameworkCore` | 10.0.12 | Aligned with EF Core packages |
| `Microsoft.EntityFrameworkCore.SqlServer` | 10.0.12 | SQL Server Express connection |
| Microsoft SQL Server | Express (.\SQLEXPRESS) | Database `GiveAidDb` |

---

## 3. Architecture & Data Model

### A. Extended User Model (`ApplicationUser.cs`)
```csharp
public class ApplicationUser : IdentityUser
{
    [Required]
    [StringLength(100)]
    public string FullName { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
```

### B. Database Integration (`ApplicationDbContext.cs`)
- Base class changed from `DbContext` to `IdentityDbContext<ApplicationUser>`.
- Preserved all 10 existing NGO domain tables: `NGOs`, `Partners`, `Causes`, `Donations`, `Programmes`, `ProgrammeInterests`, `GalleryImages`, `ContactQueries`, `Invitations`, `AboutSections`.
- `Donation.UserId` remains pre-wired to reference `AspNetUsers.Id`.

### C. Generated Identity Tables
The `AddIdentity` migration safely added standard Identity tables without disturbing existing data:
1. `AspNetUsers`
2. `AspNetRoles`
3. `AspNetUserRoles`
4. `AspNetUserClaims`
5. `AspNetUserLogins`
6. `AspNetUserTokens`
7. `AspNetRoleClaims`

---

## 4. Role-Based Access Control & Security

### A. Role Hierarchy
- **`User` (Default Role):** Automatically assigned to all self-registered users via `AccountController.Register`.
- **`Admin` (Privileged Role):** Created exclusively via the secure seeding pipeline or designated administrative assignment. **Self-elevation to Admin is strictly prevented.**

### B. Password Security Policy
Configured in `Program.cs`:
- Minimum length: 8 characters
- Requires digits and lowercase letters
- Account lockout: 5 failed attempts locks the account for 10 minutes
- Unique email required across all accounts

### C. Admin Credential Management
Admin credentials are **never hardcoded in source code or committed to Git**.
The `RoleSeedService` retrieves initial administrator credentials from `AdminSeed:Email` and `AdminSeed:Password` via:
1. .NET User Secrets in development:
   ```powershell
   dotnet user-secrets set "AdminSeed:Email" "admin@giveaid.org" --project GiveAid.Web
   dotnet user-secrets set "AdminSeed:Password" "GiveAid@2026!" --project GiveAid.Web
   ```
2. Environment variables in production / deployment.

---

## 5. Controllers, ViewModels & Views

### A. Controllers
- **`AccountController.cs`:**
  - `Register`: GET, POST (with AntiForgeryToken, auto-signs in, assigns `User` role)
  - `Login`: GET, POST (with lockout handling and local return URL verification)
  - `Logout`: POST (signs out via `SignInManager`, redirects to Home)
  - `AccessDenied`: GET (displays user-friendly unauthorized message)
- **`AdminController.cs`:**
  - Decorated with `[Authorize(Roles = "Admin")]`
  - Unauthorized visitors or regular users are immediately redirected to `/Account/AccessDenied`

### B. ViewModels
- `RegisterViewModel.cs`: `FullName`, `Email`, `Password`, `ConfirmPassword` with validation attributes.
- `LoginViewModel.cs`: `Email`, `Password`, `RememberMe`, `ReturnUrl`.

### C. Razor Views
- `Views/Account/Register.cshtml`: Responsive card with floating labels, brand icons, and client/server validation.
- `Views/Account/Login.cshtml`: Clean sign-in experience matching Give-AID deep teal / warm crimson theme.
- `Views/Account/AccessDenied.cshtml`: Polite message explaining administrative access requirements.
- `Views/Admin/Index.cshtml`: Dashboard placeholder confirming RBAC authorization.

---

## 6. Shared Layout & Navbar Updates

`Views/Shared/_Navbar.cshtml` dynamically renders based on `User.Identity.IsAuthenticated`:
- **Anonymous Users:** Displays "Sign In", "Register", and "Donate Now" CTA.
- **Authenticated Users:** Displays user avatar badge with username dropdown menu containing Sign Out.
- **Admin Users:** Displays dedicated "Admin Portal" button in navbar and dropdown menu.

---

## 7. Acceptance Checklist

- [x] ASP.NET Core Identity integrated into existing `GiveAid.Web` MVC project.
- [x] `ApplicationUser` entity with `FullName` and `CreatedAt` created.
- [x] `ApplicationDbContext` inherits `IdentityDbContext<ApplicationUser>`.
- [x] Identity migration `AddIdentity` created and applied to `GiveAidDb` on SQL Server Express.
- [x] All 10 existing domain tables preserved without data loss or dropping.
- [x] `AccountController` with Register, Login, Logout, and AccessDenied actions.
- [x] `AdminController` protected by `[Authorize(Roles = "Admin")]`.
- [x] Views styled with Give-AID design system (Teal, Crimson, Accessible forms).
- [x] Idempotent `RoleSeedService` created for `Admin` and `User` roles.
- [x] No hardcoded passwords in source code.
- [x] Build compiles cleanly with 0 errors and 0 warnings.
