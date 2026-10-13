# Task 6 — Database Design and Entity Framework Core Setup

**Project:** Give-AID — NGO Management & Donation Website  
**Task Number:** 6  
**Status:** ✅ Completed  
**Completed On:** 2026-10-13

---

## Overview

Task 6 established the full relational database schema for the Give-AID application using Entity Framework Core Code-First with SQL Server. All entity models, the `ApplicationDbContext`, the initial migration, and the live database were created and verified.

---

## Technology Versions

| Component | Version |
|-----------|---------|
| .NET SDK | 10.0.401 (net10.0) |
| EF Core SqlServer | 10.0.12 |
| EF Core Tools | 10.0.12 |
| EF Core Design | 10.0.12 |
| dotnet-ef (global) | 10.0.12 |
| SQL Server | Express (.\SQLEXPRESS) |
| Database | GiveAidDb |

---

## Entity Models Created

Ten domain entities were defined under `GiveAid.Web/Models/`:

### 1. NGO (`NGO.cs`)
Core NGO profile entity. Stores name, description, logo URL, mission, contact details, and founding year.

### 2. Partner (`Partner.cs`)
Represents affiliated partner organizations. Includes name, logo, website URL, and category.

### 3. Cause (`Cause.cs`)
Charitable campaigns with fundraising targets. Key fields:
- `TargetAmount` and `CurrentAmount` — `decimal(18,2)` precision
- `IsActive` flag for visibility control
- Navigation: `NgoId` → `NGO` (Restrict delete), `Donations` collection

### 4. Donation (`Donation.cs`)
Financial contribution records (simulated — no real card data stored). Key fields:
- `TransactionReference` — unique index
- `Amount` — `decimal(18,2)` precision
- `PaymentStatus` — Completed / Failed / Pending
- `IsSimulated = true` by default
- `UserId` (`string?`) — pre-wired for ASP.NET Core Identity link (Task 7+)
- Navigation: `CauseId` → `Cause` (Restrict delete)

### 5. Programme (`Programme.cs`)
Community welfare events and programs. Includes date, location, capacity, and status flags.

### 6. ProgrammeInterest (`ProgrammeInterest.cs`)
Volunteer and participant applications. Composite unique index on `(ProgrammeId, ApplicantEmail)` prevents duplicate submissions. Cascade delete from Programme.

### 7. GalleryImage (`GalleryImage.cs`)
Photo gallery entries. Optional `ProgrammeId` FK with SetNull on delete (preserves images if programme is removed).

### 8. ContactQuery (`ContactQuery.cs`)
Incoming contact form submissions. Includes sender name, email, subject, message, and read/replied status flags.

### 9. Invitation (`Invitation.cs`)
Event invitation tracking. Linked to programme and recipient details.

### 10. AboutSection (`AboutSection.cs`)
CMS-style key-value sections for About page content. `SectionKey` has a unique index to prevent duplicate section keys.

---

## ApplicationDbContext

**File:** `GiveAid.Web/Data/ApplicationDbContext.cs`  
**Base Class:** `DbContext` *(to be changed to `IdentityDbContext<ApplicationUser>` in Task 7)*

### DbSets Registered
```
NGOs, Partners, Causes, Donations, Programmes, ProgrammeInterests,
GalleryImages, ContactQueries, Invitations, AboutSections
```

### Fluent API Configuration
- Decimal precision on `Cause.TargetAmount`, `Cause.CurrentAmount`, `Donation.Amount` → `decimal(18,2)`
- Unique indexes: `Donation.TransactionReference`, `AboutSection.SectionKey`, `ProgrammeInterest.(ProgrammeId, ApplicantEmail)`
- Delete behaviors: Restrict (Cause→NGO, Donation→Cause), SetNull (GalleryImage→Programme), Cascade (ProgrammeInterest→Programme)

---

## Database Connection

**Connection String (appsettings.json):**
```
Server=.\SQLEXPRESS;Database=GiveAidDb;Integrated Security=True;TrustServerCertificate=True;MultipleActiveResultSets=true
```
Windows Authentication — no credentials required.

---

## Migration Applied

| Migration | Status |
|-----------|--------|
| `20261013091636_InitialCreate` | ✅ Applied |

**Command used:**
```powershell
dotnet ef database update --project GiveAid.Web
```

---

## Database Tables Created

Verified in SQL Server Express (`.\SQLEXPRESS`, database `GiveAidDb`):

| Table | Source Entity |
|-------|--------------|
| `AboutSections` | AboutSection |
| `Causes` | Cause |
| `ContactQueries` | ContactQuery |
| `Donations` | Donation |
| `GalleryImages` | GalleryImage |
| `Invitations` | Invitation |
| `NGOs` | NGO |
| `Partners` | Partner |
| `ProgrammeInterests` | ProgrammeInterest |
| `Programmes` | Programme |
| `__EFMigrationsHistory` | EF Core system table |

---

## Acceptance Checklist

- [x] 10 entity models created with proper annotations and XML docs
- [x] `ApplicationDbContext` configured with all DbSets
- [x] Fluent API: decimal precision, delete behaviors, unique indexes
- [x] Connection string configured in `appsettings.json`
- [x] `AddDbContext<ApplicationDbContext>` registered in `Program.cs`
- [x] `InitialCreate` migration generated and applied
- [x] `GiveAidDb` database created and all 10 tables verified in SSMS
- [x] `dotnet-ef` global tool version 10.0.12 installed
- [x] Build: 0 errors, 0 warnings

---

## Notes for Task 7

- `ApplicationDbContext` base class **must be changed** from `DbContext` to `IdentityDbContext<ApplicationUser>` in Task 7
- This will trigger a new migration (`AddIdentity`) that only **adds** Identity tables — existing tables are untouched
- `Donation.UserId` (`string?`, length 450) is pre-planned to link to `AspNetUsers.Id` once Identity is available
