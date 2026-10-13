# Task 8 — Home and About Us Pages

**Project:** Give-AID — NGO Management & Donation Website  
**Task Number:** 8  
**Status:** ✅ Completed  
**Completed On:** 2026-10-13

---

## 1. Overview

Task 8 delivers the public-facing landing and institutional information foundation for the Give-AID web platform. This includes:
1. A conversion-focused, accessible, and responsive **Home Page** (`/` and `/Home/Index`) showcasing humanitarian impact, featured causes, upcoming welfare camps, and accredited NGO partners.
2. An extensive, structured **About Us Page** (`/Home/About`) fulfilling all **seven mandatory functional requirements** (`FR-007` to `FR-014`).

---

## 2. Technical Stack & Implementation

| Layer | Component | Details |
|---|---|---|
| **Framework** | ASP.NET Core MVC (net10.0) | Target framework aligned with .NET 10 SDK |
| **Controller** | `HomeController.cs` | Asynchronously queries EF Core context with graceful demo fallback |
| **ViewModels** | `HomeIndexViewModel.cs` & `AboutViewModel.cs` | Strongly-typed view models separating presentation from database domain entities |
| **Razor Views** | `Index.cshtml` & `About.cshtml` | Accessible semantic markup with Give-AID theme styling |
| **Styles** | `wwwroot/css/site.css` | Custom components: hero banner, progress bars, date boxes, team cards, milestone badges |

---

## 3. Home Page Specifications (`FR-001` to `FR-006`)

### A. Hero Section (FR-001)
- **Headline:** *"Empowering Communities, Transforming Lives with Hope & Dignity"*
- **Description:** Clear explanation of Give-AID's mission connecting donors with certified local NGOs.
- **Primary CTA:** Branded "Donate Now" button linking directly to the donation module (`/Donate`).
- **Secondary CTA:** "Learn More About Us" link navigating to `/Home/About`.
- **Trust Highlights Box:** Displays verifiable platform principles (100% Traceable Distributions, Accredited NGO Partners, Zero Financial Card Numbers Stored).

### B. Organisation Impact (FR-004)
- **Funds Mobilized:** PKR 14.5M+ (Demonstration baseline or cumulative database total)
- **Lives Touched:** 28,500+ across medical, water, and emergency food drives
- **Welfare Projects Completed:** 64+ in arid and vulnerable areas
- **Registered Volunteers:** 480+ active participants
- Explicitly labelled with a demonstration baseline disclaimer.

### C. Featured Causes (FR-002)
- Grid displaying 3 active humanitarian causes (e.g. *Clean Water for Thar Communities*, *Emergency Medical Aid for Flood Districts*, *Orphan Education Kits*).
- Visual progress bar showing Goal, Current Raised, and Percentage Funded.
- Direct "Support This Cause" action button.

### D. Upcoming Programmes (FR-003)
- Chronological cards featuring upcoming welfare events with custom calendar date boxes (Day & Month).
- Includes venue location pin, status badges, and "Volunteer / Details" links (`/Programmes`).

### E. Partners & Supporters (FR-005)
- Displays accredited partner NGOs (e.g., *Al-Khidmat Foundation Alliance*, *Edhi Community Network*) and corporate sponsors (*Tech for Good Foundation*, *Global Health Relief Society*).
- Outlines partnership categories and mission bios.

### F. Ways to Get Involved & Call to Action
- Three distinct participation pathways: Financial Contribution, Field Volunteering, and Social Advocacy.
- Final high-impact call-to-action banner.

---

## 4. About Us Page Specifications (`FR-007` to `FR-014`)

The About Us view includes an in-page sticky jump navigation allowing instant scrolling to all seven required sections:

| # | Section ID | Title | FR Mapping | Core Contents |
|---|---|---|---|---|
| 1 | `#what-we-do` | What We Do | `FR-007` | 5 focus areas: Emergency Healthcare, Clean Drinking Water, Food Security, Child Education, Disaster Relief. |
| 2 | `#our-mission` | Our Mission & Vision | `FR-008` | Official Mission Statement, Vision Statement, and 5 Core Values (Transparency, Dignity, Grassroots Collaboration, Measurable Impact, Inclusivity). |
| 3 | `#our-team` | Our Team | `FR-009` | Leadership profiles with role badges (Executive Trustee, Medical Advisor, Operations Lead, Volunteer Coordinator), marked with `[Demonstration Profile]` notices. |
| 4 | `#career-with-us` | Career With Us | `FR-010` | Volunteer & fellowship policy, 3 open demonstration volunteer roles with application guidelines linking to Programmes portal. |
| 5 | `#our-achievements` | Our Achievements | `FR-011` | Milestone timeline (2024 Thar Water Initiative, 2025 Mobile Clinics, 2026 Give-AID Digital Platform) with verifiable impact metrics. |
| 6 | `#our-supporters` | Our Supporters | `FR-012` | Institutional patrons, healthcare logistics partners, academic consortiums, and advisory groups. |
| 7 | `#read-about-us` | Read About Us | `FR-013` | Institutional inception narrative under Software Engineering curriculum, audited governance charter, and annual reporting notes. |

---

## 5. Verification & Smoke Test Results

All routes were verified live via an active ASP.NET Core server test on `http://127.0.0.1:5100`:

| Endpoint | Method | Expected Status | Result | Details |
|---|---|---|---|---|
| `/` | GET | 200 OK | ✅ Passed | Rendered Hero, Causes, Programmes, Impact, Partners |
| `/Home/Index` | GET | 200 OK | ✅ Passed | Full layout and data binding verified |
| `/Home/About` | GET | 200 OK | ✅ Passed | Confirmed all 7 section DOM elements present |
| `/Account/Login` | GET | 200 OK | ✅ Passed | Auth system integrity intact |
| `/Account/Register`| GET | 200 OK | ✅ Passed | User registration form intact |

`dotnet build` produced **0 errors** and **0 warnings**.
