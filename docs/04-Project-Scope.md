# Give-AID — Project Scope & Boundaries Specification

**Document ID:** `DOC-04`  
**Project Name:** Give-AID — NGO Management & Donation Website  
**Status:** Approved for Task 1 Requirements Baseline  
**Date:** October 2026  

---

## 1. Executive Summary of Project Boundaries

Defining clear boundaries is essential for the successful completion of the Give-AID eProject. This document establishes what is strictly within the development baseline (**In-Scope**), what is explicitly omitted (**Out-of-Scope**), optional extensions requiring prior instructor approval, and the foundational assumptions governing implementation.

---

## 2. In-Scope Features (First Release Baseline)

The following features represent the confirmed development baseline to be implemented across the 20 roadmap tasks:

### 2.1 Public Front-Facing Portal
- **Home Page:** Hero banner, Call to Action (`Donate`), featured causes, upcoming events highlight, impact metrics, and partner logos.
- **About Us (7 Mandatory Sections):** *What We Do*, *Our Mission*, *Our Team*, *Career With Us*, *Our Achievements*, *Our Supporters*, *Read About Us*.
- **Causes & Campaigns:** Public catalog of causes with detail views, progress indicators, and donation triggers.
- **Welfare Programmes:** Event listings segregated into **Upcoming Programmes** and **Past Programmes** with chronological sorting.
- **Photo Gallery:** Accessible grid of community activity images with category/programme filtering and preview dialogs.
- **NGO & Partners:** Public profiles of participating non-governmental organizations and corporate sponsors.
- **Help Centre & Contact:** Comprehensive FAQ accordion, inquiry submission form (`Contact Us`), and validation feedback.

### 2.2 User Authentication & Profile
- **ASP.NET Core Identity Integration:** Registration, secure login, and logout.
- **Role Assignment:** Automatic assignment of default `User` role to new registrants; automated seed for initial `Admin`.
- **Donor History & Receipts:** Personal member portal showing past simulated donations with itemized digital receipts.
- **Programme Participation:** Submission form for expressing volunteer or participant interest in upcoming events with duplicate prevention.
- **"Invite a Friend":** Referral email invitation submission form with input validation and rate protection.

### 2.3 Administrative Back-Office (`/Admin`)
- **Secured Admin Shell:** Master admin layout with role-based authorization filter.
- **Operational Dashboard:** Consolidated statistical counters (Causes, Total Donations, Active Programmes, Pending Inquiries, Volunteer Submissions).
- **Module Management (CRUD):**
  - Causes management (Create, Read, Update, Delete with image upload).
  - Programmes management (Create, Edit dates/venues, Cancel, Archive).
  - NGOs & Partners management (Maintain profiles and logo uploads).
  - Gallery curation (Image upload with sanitization, metadata, and deletion).
  - Inquiries moderation (Review queries, status toggling `Pending`/`Reviewed`/`Closed`, admin notes).
  - Volunteer requests moderation (Review expressions of interest, approve/decline).
  - Donation audits (Search and review platform-wide donation logs).

---

## 3. Out-of-Scope Features (Explicitly Excluded)

To maintain academic focus, project safety, and prevent scope creep, the following capabilities are explicitly excluded from this release:

1. **Real Payment Gateway Integration:** No live integration with Stripe, PayPal, Authorize.Net, EasyPaisa, or JazzCash APIs in production mode.
2. **Payment Card Data Ingestion:** Storing, decrypting, or transmitting real credit card numbers, CVVs, or cardholder bank data is strictly out of scope.
3. **Native Mobile Applications:** No iOS or Android native mobile apps (the responsive web application serves mobile web browsers).
4. **Multi-Currency Live Forex Conversion:** Donations will be tracked in a single default currency (PKR or USD as configured).
5. **Multi-Language Internationalization (i18n):** The system will be presented in English with intuitive UI cues.
6. **Full-Blown Financial Accounting & Payroll:** Complex corporate double-entry ledger bookkeeping, payroll, and tax filings for NGO employees are excluded.
7. **E-Commerce Merchandise Store:** Selling physical goods, inventory warehousing, and postal shipping tracking are excluded.

---

## 4. Optional Features (Requiring Explicit Instructor Approval)

The following capabilities are considered secondary enhancements. They will remain deferred until all Must-Have requirements in Tasks 01–18 are completed and verified:

| Feature | Proposed Scope | Approval Status |
| :--- | :--- | :--- |
| **Live SMTP Email Delivery** | Sending real transactional emails via Gmail SMTP or SendGrid rather than local mock logging. | **Pending / Optional** (Mock email logging is the default safety baseline). |
| **PDF Receipt Export** | Generating downloadable PDF receipts using an open-source library (e.g., QuestPDF or DinkToPdf) rather than printable HTML receipts. | **Optional** (Print-friendly HTML receipt view is the baseline). |
| **External Social Login** | Allowing OAuth2 login via Google or Microsoft accounts alongside local Identity. | **Optional** (Local ASP.NET Identity accounts are the baseline). |
| **Live Chat Widget** | Real-time SignalR chat between visitors and administrators. | **Out of Scope / Optional** (Standard Contact Query ticketing is the baseline). |

---

## 5. Foundational Assumptions

1. **Academic eProject Context:** The application is developed as an independent Software Engineering student project fulfilling institutional grading criteria.
2. **Modern Technology Stack:** The application utilizes ASP.NET Core MVC (C#), Entity Framework Core, SQL Server, and Bootstrap 5 in Visual Studio on Windows.
3. **Simulated Financial Transactions:** The donation workflow simulates real-world payment outcomes reliably and deterministically for demonstration purposes without financial liability.
4. **Development Data Seeding:** Initial demonstration records (seed causes, mock programmes, sample partners, default admin user) will be provisioned via safe database seeding scripts.
5. **Storage of Media Files:** Uploaded media (logos, photos) are saved to web server physical storage (`wwwroot/uploads/`) with unique sanitized GUID filenames, storing relative URLs in the database.

---

## 6. Unresolved Questions & Missing Documents Log

| Item / Document | Status | Impact | Action Required |
| :--- | :--- | :--- | :--- |
| **`NGO-website.doc`** | **Missing from workspace** | Contains legacy eProject problem specifications and grading criteria. | User can supply the document or proceed with the modern roadmap (`tasks/01-20`) as the definitive specification baseline. |
| **`Project Specification - NGO.DOC`** | **Missing from workspace** | Contains legacy specification details. | Baseline is derived from existing comprehensive `tasks/*.md` documents. |
| **`plan.md`** | **Missing from workspace** | Referenced in `README.md`. | Replaced and formalized by the current `docs/` specification suite. |
| **Target .NET SDK Version** | **Pending confirmation** | Determines the .NET runtime target (`net8.0` LTS recommended). | Will be checked and recorded during Task 2 environment verification. |
| **Email Protocol Strategy** | **Clarified baseline** | Avoids accidental disclosure of SMTP passwords in source code. | Decoupled via `IEmailSender` using local console/file logging by default. |
