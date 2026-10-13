# TASK-08 — Home and About Us pages

**Status:** Completed  
**Dependencies:** Task 05  
**Completed Date:** 2026-10-13  

## Objective

Build the main public landing page and the required About Us content.

## Steps

1. [x] Create a Home view with a clear hero message and Donate call to action (`Views/Home/Index.cshtml`, `HomeIndexViewModel.cs`).
2. [x] Add sections for featured causes, upcoming programmes, organisation impact and partners; use sample data or placeholders until database-driven features exist.
3. [x] Create About Us sections: What We Do, Our Mission, Our Team, Career With Us, Our Achievements, Our Supporters and Read About Us (`Views/Home/About.cshtml`, `AboutViewModel.cs`).
4. [x] Ensure all content has a readable layout, accessible markup, and relevant image alt text.
5. [x] Keep navigation consistent and verify all page routes (`/`, `/Home/Index`, `/Home/About`).
6. [x] Document any content that should later be managed from the admin area (`AboutSection` entity, `docs/16-Home-and-About-Pages.md`).

## Acceptance criteria

- [x] Home and About pages render without exceptions (HTTP 200 OK verified).
- [x] All 7 required About Us sections are present and verified live.
- [x] Calls to action and navigation links work (Donate Now, Learn More, section jump nav).

## Expected outputs

- `Home and About Razor views`: `Views/Home/Index.cshtml`, `Views/Home/About.cshtml`
- `Updated route/navigation notes`: `_Navbar.cshtml` with dynamic active tab state; `docs/16-Home-and-About-Pages.md`

## Blocker log

None.

## Completion notes

- **Date completed:** 2026-10-13
- **Tests performed:** 
  1. `dotnet build` succeeded with 0 errors and 0 warnings.
  2. Live web server smoke test on port 5100:
     - `GET /` -> HTTP 200 OK. Confirmed Hero, Featured Causes, Upcoming Programmes, Impact Statistics, and Partners sections.
     - `GET /Home/About` -> HTTP 200 OK. Confirmed presence of all 7 sections (`#what-we-do`, `#our-mission`, `#our-team`, `#career-with-us`, `#our-achievements`, `#our-supporters`, `#read-about-us`).
     - `GET /Account/Login` & `GET /Account/Register` -> HTTP 200 OK.
- **Evidence / screenshot path:** `docs/16-Home-and-About-Pages.md`
- **Git commit:** Pending user approval
- **Follow-up work, if any:** None for Task 8. Await approval before Task 9.

