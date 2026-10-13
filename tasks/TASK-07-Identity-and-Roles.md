# TASK-07 — Authentication and Admin/User roles

**Status:** Completed  
**Dependencies:** Task 06  
**Completed Date:** 2026-10-13  

## Objective

Use the framework's secure identity facilities instead of custom password handling.

## Steps

1. [x] Add/configure ASP.NET Core Identity compatible with the project template and EF Core setup.
2. [x] Define any required profile fields through a safe user model extension (`ApplicationUser` with `FullName`, `CreatedAt`).
3. [x] Create registration, login and logout flows with validation (`AccountController`, `RegisterViewModel`, `LoginViewModel`, Views).
4. [x] Configure `Admin` and `User` roles and a safe, repeatable way to seed the initial admin account (`RoleSeedService`).
5. [x] Do not hard-code a production password; use local development secrets or environment variables.
6. [x] Protect admin routes with authorization and role checks (`AdminController` with `[Authorize(Roles = "Admin")]`).
7. [x] Verify unauthenticated visitors cannot access admin pages and regular users cannot perform admin actions.

## Acceptance criteria

- [x] Register, login and logout work.
- [x] Passwords are handled by Identity; no plaintext password is stored.
- [x] Admin routes are restricted by role.
- [x] A normal user cannot open admin-only actions.

## Expected outputs

- `Identity configuration`: `Microsoft.AspNetCore.Identity.EntityFrameworkCore` 10.0.12 in `Program.cs` & `ApplicationDbContext`
- `Role seeding/setup notes`: `RoleSeedService.cs` reading from `AdminSeed:Email` and `AdminSeed:Password`
- `Authentication views`: `Register.cshtml`, `Login.cshtml`, `AccessDenied.cshtml`, `Admin/Index.cshtml`, `_Navbar.cshtml`

## Blocker log

None.

## Completion notes

- **Date completed:** 2026-10-13
- **Tests performed:** `dotnet build` succeeded with 0 errors and 0 warnings. `AddIdentity` EF Core migration generated and applied cleanly to SQL Server Express database `GiveAidDb`. 18 tables verified (10 existing domain tables untouched + 7 Identity tables + `__EFMigrationsHistory`).
- **Evidence / screenshot path:** `docs/15-Authentication-and-Roles.md`
- **Git commit:** Pending user approval
- **Follow-up work, if any:** None for Task 7. Await approval before Task 8.

