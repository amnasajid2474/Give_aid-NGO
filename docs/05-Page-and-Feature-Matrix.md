# Give-AID — Page & Feature Traceability Matrix

**Document ID:** `DOC-05`  
**Project Name:** Give-AID — NGO Management & Donation Website  
**Status:** Approved for Task 1 Requirements Baseline  
**Date:** October 2026  

---

## 1. Overview

The Page and Feature Matrix provides complete traceability between web application routes, user interfaces, security permissions, user roles, and the functional requirements (`FR-xxx`) established in `docs/02-Functional-Requirements.md`.

---

## 2. Master Page & Feature Matrix

| Route / Page | Intended User | Key Features & Purpose | Authentication Level | Admin Functionality Included? | Related Requirements |
| :--- | :--- | :--- | :--- | :--- | :--- |
| **`/Home/Index`** (Home) | Public Visitor | Hero banner, Donate CTA, featured causes, upcoming events, impact statistics, partner logos. | Anonymous (None) | No | `FR-001`, `FR-002`, `FR-003`, `FR-004`, `FR-005`, `FR-006` |
| **`/Home/About`** (About Us) | Public Visitor | Informational display of 7 mandatory sections: What We Do, Mission, Team, Careers, Achievements, Supporters, Read About Us. | Anonymous (None) | Content managed via admin in later task | `FR-007`, `FR-008`, `FR-009`, `FR-010`, `FR-011`, `FR-012`, `FR-013`, `FR-014` |
| **`/Causes/Index`** (Causes Catalog) | Public Visitor | Grid of all active social causes with summaries, images, goal progress, and donation buttons. | Anonymous (None) | No | `FR-015`, `FR-017` |
| **`/Causes/Details/{id}`** | Public Visitor | Deep dive into cause objectives, backstory, associated NGO, and embedded donation form. | Anonymous (None) | No | `FR-016` |
| **`/Donate/Index`** (Donation Page) | Public Visitor / Member | Select cause, choose/enter amount, input donor name and contact, initiate simulated payment. | Anonymous or Authenticated | No | `FR-020`, `FR-021`, `FR-022`, `FR-023` |
| **`/Donate/Confirmation/{id}`** | Public Visitor / Member | Digital receipt display with non-sensitive transaction reference code, cause name, and amount. | Public / Member | No | `FR-024` |
| **`/Programmes/Index`** | Public Visitor | Catalog of welfare events segregated into Upcoming Programmes and Past Programmes. | Anonymous (None) | No | `FR-038` |
| **`/Programmes/Details/{id}`** | Public Visitor | Full programme agenda, date, venue, objectives, and volunteer participation trigger. | Anonymous (None) | No | `FR-039` |
| **`/Programmes/Interest/{id}`** | Member / Visitor | Submission form to register interest or volunteer for a specific event with duplicate check. | Required for tracking (Member or Guest) | No | `FR-040`, `FR-041` |
| **`/Gallery/Index`** | Public Visitor | Visual grid of high-resolution project images, category filters, and modal preview dialogs. | Anonymous (None) | No | `FR-044`, `FR-045`, `FR-046` |
| **`/Partners/Index`** | Public Visitor | Listing of accredited NGO affiliates and corporate partners with bios and links. | Anonymous (None) | No | `FR-033` |
| **`/Partners/Details/{id}`** | Public Visitor | Profile of specific partner or NGO with supported causes and contact points. | Anonymous (None) | No | `FR-034` |
| **`/Help/Index`** & **`/Help/Faq`** | Public Visitor | Searchable and expandable FAQ accordion answering donor and volunteer questions. | Anonymous (None) | No | `FR-049` |
| **`/Contact/Index`** (Contact Us) | Public Visitor | Contact inquiry form with server-side validation and immediate feedback banner. | Anonymous (None) | No | `FR-050`, `FR-051` |
| **`/Invite/Index`** | Registered Member | Friend referral form to share NGO mission via email with rate limiting. | Authenticated (`User`, `Admin`) | No | `FR-055`, `FR-056` |
| **`/Account/Register`** | Public Visitor | Account registration form with client & server validation and automatic password hashing. | Anonymous (None) | No | `FR-027` |
| **`/Account/Login`** | Public Visitor | Secure login view with remember-me and lockout handling via ASP.NET Core Identity. | Anonymous (None) | No | `FR-028` |
| **`/Account/Logout`** | Registered Member | Form post to invalidate session cookies and redirect to Home view. | Authenticated | No | `FR-029` |
| **`/Account/Profile`** | Registered Member | View and update personal profile details and change password securely. | Authenticated (`User`, `Admin`) | No | `FR-032` |
| **`/Account/Donations`** | Registered Member | Private history view of the authenticated user's past simulated donations and receipt links. | Authenticated (`User`, `Admin`) | No | `FR-025` |
| **`/Admin/Index`** (Dashboard) | Administrator | High-level metrics (Total causes, donation total, pending queries, volunteer count) and module links. | Restricted (`Admin` role) | **Yes (Full Dashboard)** | `FR-059`, `FR-060`, `FR-061`, `FR-062` |
| **`/Admin/Causes/*`** | Administrator | Full CRUD (Create, Read, Edit, Delete, Toggle Active) for charitable causes with image uploads. | Restricted (`Admin` role) | **Yes (CRUD)** | `FR-018`, `FR-019`, `FR-064` |
| **`/Admin/Programmes/*`** | Administrator | Full CRUD for welfare events (Add, Update schedules, Cancel, Delete). | Restricted (`Admin` role) | **Yes (CRUD)** | `FR-042`, `FR-064` |
| **`/Admin/Interests/*`** | Administrator | Review volunteer and participant expressions of interest; mark status (`Approved`/`Declined`). | Restricted (`Admin` role) | **Yes (Moderation)** | `FR-043` |
| **`/Admin/Gallery/*`** | Administrator | Image asset manager: upload pictures, set captions/alt text, associate programmes, and delete. | Restricted (`Admin` role) | **Yes (CRUD)** | `FR-047`, `FR-048`, `FR-064` |
| **`/Admin/Ngos/*`** | Administrator | Full CRUD for affiliated NGO organizational profiles and logos. | Restricted (`Admin` role) | **Yes (CRUD)** | `FR-035`, `FR-037`, `FR-064` |
| **`/Admin/Partners/*`** | Administrator | Full CRUD for corporate partners and sponsor profiles. | Restricted (`Admin` role) | **Yes (CRUD)** | `FR-036`, `FR-037`, `FR-064` |
| **`/Admin/Queries/*`** | Administrator | Review visitor inquiries, record internal resolution notes, toggle status (`Reviewed`/`Closed`). | Restricted (`Admin` role) | **Yes (Ticket Management)** | `FR-052`, `FR-053` |
| **`/Admin/Donations/*`** | Administrator | Search, audit, and inspect all platform-wide simulated donations and transaction references. | Restricted (`Admin` role) | **Yes (Audit Log)** | `FR-026` |
| **`/Admin/Users/*`** | Administrator | Inspect registered member list and monitor system security roles. | Restricted (`Admin` role) | **Yes (User Oversight)** | `FR-065` |

---

## 3. Role Access Summary Table

| Functional Area | Anonymous Visitor | Registered User / Member | System Administrator |
| :--- | :---: | :---: | :---: |
| Browse Public Information (Home, About, Causes, Programmes, Gallery) | ✅ Allowed | ✅ Allowed | ✅ Allowed |
| Submit Simulated Donation | ✅ Allowed (Guest) | ✅ Allowed (Linked to Account) | ✅ Allowed |
| View Personal Donation History & Receipts | ❌ Denied | ✅ Allowed (Own Only) | ✅ Allowed (Own Only) |
| Submit Programme Volunteer Interest | ✅ Allowed | ✅ Allowed | ✅ Allowed |
| Submit Contact Inquiry | ✅ Allowed | ✅ Allowed | ✅ Allowed |
| Access Admin Dashboard & CRUD Operations | ❌ Denied (403/Redirect) | ❌ Denied (403/Redirect) | ✅ Allowed |
| Platform-Wide Audit & Moderation | ❌ Denied | ❌ Denied | ✅ Allowed |
