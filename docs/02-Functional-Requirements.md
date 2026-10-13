# Give-AID — Functional Requirements Specification

**Document ID:** `DOC-02`  
**Project Name:** Give-AID — NGO Management & Donation Website  
**Status:** Approved for Task 1 Requirements Baseline  
**Date:** October 2026  

---

## 1. Overview of Functional Requirements

This specification defines the functional behaviors, system interactions, and operational features of the Give-AID web platform. Each requirement is assigned a permanent, unique identifier (`FR-xxx`), prioritized using MoSCoW methodology (**Must Have**, **Should Have**, **Could Have**), and mapped to target user roles.

---

## 2. Module Breakdown and Requirements Catalog

### Module 1: Home Page & Public Navigation

| Requirement ID | Title | Description | Target Role | Priority |
| :--- | :--- | :--- | :--- | :--- |
| **FR-001** | Hero Banner & Primary Call-to-Action | The system shall display a prominent hero section on the Home page featuring an inspiring headline, organizational slogan, and a primary "Donate Now" call-to-action button linking directly to the donation workflow. | Public Visitor | Must Have |
| **FR-002** | Featured Causes Showcase | The Home page shall display a curated section of featured charitable causes showing cause title, brief synopsis, thumbnail image, and progress indicator. | Public Visitor | Must Have |
| **FR-003** | Upcoming Programmes Highlight | The Home page shall display a chronological summary of upcoming welfare events and programmes with date, venue, and a link to view details. | Public Visitor | Must Have |
| **FR-004** | Impact Statistics Display | The Home page shall display key organizational achievements and metrics (e.g., total funds mobilized, lives touched, active partner NGOs, completed initiatives). | Public Visitor | Must Have |
| **FR-005** | Partner Logos Showcase | The Home page shall feature a dedicated section displaying approved partner NGO and corporate sponsor logos. | Public Visitor | Must Have |
| **FR-006** | Global Navigation & Footer | The shared layout shall provide consistent, accessible header navigation (Home, Causes, Programmes, About Us, Gallery, Partners, Help, Contact, Donate, Login/Register) and a footer containing copyright, quick links, contact info, and legal disclaimer. | Public Visitor | Must Have |

---

### Module 2: About Us & Organizational Content

| Requirement ID | Title | Description | Target Role | Priority |
| :--- | :--- | :--- | :--- | :--- |
| **FR-007** | What We Do Section | The system shall present a dedicated narrative detailing the NGO's scope of operations, social focus areas, and humanitarian aid sectors. | Public Visitor | Must Have |
| **FR-008** | Our Mission & Vision Section | The system shall display the official mission statement, core guiding values, and long-term vision of the Give-AID initiative. | Public Visitor | Must Have |
| **FR-009** | Our Team Section | The system shall display profiles of key leadership members, trustees, and operational staff including names, roles, and introductory bios. | Public Visitor | Must Have |
| **FR-010** | Career With Us Section | The system shall display an employment and volunteering opportunities notice explaining how professionals and volunteers can join the team. | Public Visitor | Must Have |
| **FR-011** | Our Achievements Section | The system shall present notable milestones, awards, project completions, and verifiable impact summaries. | Public Visitor | Must Have |
| **FR-012** | Our Supporters Section | The system shall showcase major donors, institutional grants, and supporting community patrons. | Public Visitor | Must Have |
| **FR-013** | Read About Us Section | The system shall provide detailed background reading, organizational history, press mentions, and published reports. | Public Visitor | Must Have |
| **FR-014** | Admin Content Manageability | The system shall support administrative modification or designated configuration of key About Us informational sections. | Administrator | Should Have |

---

### Module 3: Causes & Campaigns

| Requirement ID | Title | Description | Target Role | Priority |
| :--- | :--- | :--- | :--- | :--- |
| **FR-015** | Public Causes Catalog | The system shall provide a public catalog page displaying all active charitable causes with title, category, description, and visual assets. | Public Visitor | Must Have |
| **FR-016** | Cause Detail View | Visitors shall be able to view an in-depth cause detail page displaying full campaign narrative, target goals, associated NGO, and a direct donation widget. | Public Visitor | Must Have |
| **FR-017** | Empty State Handling for Causes | The system shall display an informative, polite empty-state banner when no active causes match search criteria or when the database has no records. | Public Visitor | Must Have |
| **FR-018** | Cause Administrative CRUD | The system shall allow authorized administrators to create, read, update, activate/deactivate, and delete cause entries with server-side validation. | Administrator | Must Have |
| **FR-019** | Cause Image Upload Validation | The system shall validate image uploads for causes (file format, max file size, safe sanitized server-side filenames) and persist relative paths. | Administrator | Must Have |

---

### Module 4: Donation Workflow (Simulated)

| Requirement ID | Title | Description | Target Role | Priority |
| :--- | :--- | :--- | :--- | :--- |
| **FR-020** | Donation Initiation Form | The system shall present a donation form allowing users to select an active cause, specify an amount (with predefined quick-select buttons and custom entry), and supply donor contact details. | Public / Member | Must Have |
| **FR-021** | Guest and Authenticated Donation Support | The donation form shall allow both guest visitors and logged-in members to donate; logged-in member details shall pre-populate automatically. | Public / Member | Must Have |
| **FR-022** | Simulated Payment Processing | The system shall route donations through a simulated payment interface featuring deterministic outcomes (Success / Failure test cards/buttons) with zero live card storage. | Public / Member | Must Have |
| **FR-023** | Zero Sensitive Data Storage | The system shall strictly prohibit collecting, persisting, or logging real credit/debit card numbers, CVVs, expiration dates, or bank PINs. | All Roles | Must Have |
| **FR-024** | Digital Donation Receipt Generation | Upon successful simulated donation completion, the system shall generate an on-screen digital receipt displaying reference ID, timestamp, donor name, cause, amount, and payment status. | Public / Member | Must Have |
| **FR-025** | Donor Personal Donation History | The system shall allow authenticated members to access their personal donation history log, displaying all past contributions and linkable receipts. | Registered Member | Must Have |
| **FR-026** | Administrative Donation Oversight | The system shall allow administrators to search, filter, and inspect all platform-wide donation transactions with status and timestamps. | Administrator | Must Have |

---

### Module 5: User Authentication & Role Management

| Requirement ID | Title | Description | Target Role | Priority |
| :--- | :--- | :--- | :--- | :--- |
| **FR-027** | User Registration | The system shall provide a registration form allowing visitors to create an account by supplying full name, valid email address, phone number, and a secure password. | Public Visitor | Must Have |
| **FR-028** | Secure User Login | The system shall authenticate registered users using ASP.NET Core Identity with secure PBKDF2 password hashing, returning appropriate session cookies. | Public Visitor | Must Have |
| **FR-029** | User Logout | The system shall invalidate authentication cookies upon user sign-out and redirect to the public Home view. | Registered Member | Must Have |
| **FR-030** | Role-Based Authorization Enforcement | The system shall enforce role segregation with two primary roles: `Admin` and `User`. Restricted controllers and actions shall reject unauthorized access with HTTP 403 or redirect to login. | System / All | Must Have |
| **FR-031** | Initial Admin Account Seeding | The system shall provide an automated, repeatable, and idempotent seeding routine to create the initial administrative account and necessary roles without hardcoded production passwords. | System / Admin | Must Have |
| **FR-032** | User Profile Management | Authenticated members shall have access to a profile dashboard to review and update personal details (name, contact number) and change passwords. | Registered Member | Should Have |

---

### Module 6: NGO and Partner Management

| Requirement ID | Title | Description | Target Role | Priority |
| :--- | :--- | :--- | :--- | :--- |
| **FR-033** | Public NGO & Partner Showcase | The system shall provide public catalog views showcasing affiliated NGOs and corporate partners, including organizational bios, missions, and contact info. | Public Visitor | Must Have |
| **FR-034** | Partner Detail Profile | Visitors shall be able to click on any partner or NGO to view comprehensive details, active causes supported, and website references. | Public Visitor | Must Have |
| **FR-035** | Admin NGO Management (CRUD) | Administrators shall have complete CRUD capabilities over NGO records (Name, Registration Number, Mission, Address, Contact Email, Phone, Logo, Status). | Administrator | Must Have |
| **FR-036** | Admin Partner Management (CRUD) | Administrators shall have complete CRUD capabilities over Partner records (Partner Name, Type, Partnership Level, Website URL, Logo, Status). | Administrator | Must Have |
| **FR-037** | Logo Upload Sanitization | The system shall inspect and validate uploaded NGO/partner logos for valid image extensions (.jpg, .jpeg, .png, .webp), size restrictions (< 2 MB), and assign randomized safe file paths. | Administrator | Must Have |

---

### Module 7: Welfare Programmes & Participation Requests

| Requirement ID | Title | Description | Target Role | Priority |
| :--- | :--- | :--- | :--- | :--- |
| **FR-038** | Public Programmes Catalog | The system shall display a public listing of welfare programmes and events, clearly categorized into **Upcoming Programmes** and **Past Programmes**. | Public Visitor | Must Have |
| **FR-039** | Programme Detail View | Visitors shall be able to inspect full event details, including event date/time, venue, lead coordinator, objectives, and agenda. | Public Visitor | Must Have |
| **FR-040** | Volunteer / Interest Submission Form | The system shall allow visitors/members to submit an expression of interest to participate or volunteer in an upcoming programme. | Public / Member | Must Have |
| **FR-041** | Duplicate Interest Prevention | The system shall validate and prevent duplicate interest submissions for the same user and programme combination, notifying the applicant gracefully. | Public / Member | Must Have |
| **FR-042** | Admin Programme Management (CRUD) | Administrators shall be able to create, view, edit, reschedule, or cancel welfare programmes. | Administrator | Must Have |
| **FR-043** | Admin Participation Moderation | Administrators shall have access to a moderation panel to view, approve, decline, or mark participation/volunteer requests as attended. | Administrator | Must Have |

---

### Module 8: Photo Gallery

| Requirement ID | Title | Description | Target Role | Priority |
| :--- | :--- | :--- | :--- | :--- |
| **FR-044** | Public Gallery Grid | The system shall provide a responsive, accessible photo gallery displaying images of community work, relief drives, and programme events. | Public Visitor | Must Have |
| **FR-045** | Programme-Gallery Association | The system shall permit filtering or grouping gallery images by associated welfare programmes. | Public Visitor | Should Have |
| **FR-046** | Lightbox / Modal Image Inspection | Visitors shall be able to click an image to view a high-resolution preview with descriptive caption and alternative text. | Public Visitor | Should Have |
| **FR-047** | Admin Gallery Asset Upload | Administrators shall be able to upload gallery images with title, descriptive caption, alt text, and optional programme linkage. | Administrator | Must Have |
| **FR-048** | Admin Gallery Asset Deletion | Administrators shall be able to remove gallery records and safely delete the corresponding orphaned file from disk upon confirmation. | Administrator | Must Have |

---

### Module 9: Help Centre, FAQ & Inquiries

| Requirement ID | Title | Description | Target Role | Priority |
| :--- | :--- | :--- | :--- | :--- |
| **FR-049** | FAQ Knowledge Base | The system shall display a categorized, searchable Frequently Asked Questions (FAQ) accordion answering common visitor and donor questions. | Public Visitor | Must Have |
| **FR-050** | Contact Us Submission Form | The system shall present a public contact inquiry form collecting visitor name, email address, subject, message body, and optional phone number. | Public Visitor | Must Have |
| **FR-051** | Inquiry Server Validation | The system shall validate all contact form inputs on the server (email format, message character length, required fields) before persisting. | System | Must Have |
| **FR-052** | Admin Inquiry Management | Administrators shall have access to an inquiry dashboard listing all received queries with submission date, sender details, and resolution status (`Pending`, `Reviewed`, `Closed`). | Administrator | Must Have |
| **FR-053** | Admin Reply & Resolution Tracking | Administrators shall be able to record internal notes, update inquiry status, and mark inquiries as replied or resolved. | Administrator | Must Have |
| **FR-054** | Inquiry User Linking | For logged-in users who submit inquiries, the system shall link the query to their user account for personalized tracking. | Registered Member | Should Have |

---

### Module 10: Invitations & Email Communication

| Requirement ID | Title | Description | Target Role | Priority |
| :--- | :--- | :--- | :--- | :--- |
| **FR-055** | "Invite a Friend" Feature | Authenticated members shall be able to submit an invitation form specifying friend email addresses and a custom invite message to spread awareness. | Registered Member | Must Have |
| **FR-056** | Invitation Abuse Protection & Rate Limiting | The system shall enforce rate limits and server validation on invitation submissions to prevent spamming or automated bot abuse. | System | Must Have |
| **FR-057** | Email Service Abstraction | The system shall utilize an `IEmailSender` abstraction that cleanly decouples application workflows from mail delivery mechanisms. | System | Must Have |
| **FR-058** | Safe Mail Transport Configuration | When real SMTP credentials are not configured, the system shall log email payloads to development output or local mock logs without crashing or falsely claiming delivery. | System | Must Have |

---

### Module 11: Admin Dashboard & Back-Office Integration

| Requirement ID | Title | Description | Target Role | Priority |
| :--- | :--- | :--- | :--- | :--- |
| **FR-059** | Protected Administration Portal | The system shall provide a dedicated administrative shell (`/Admin`) protected by `[Authorize(Roles = "Admin")]` attribute verification. | Administrator | Must Have |
| **FR-060** | Operational KPI Metrics | The dashboard shall display live summary cards derived from real database counts (Total Causes, Total Donations Amount, Active Programmes, Pending Inquiries, Volunteer Requests). | Administrator | Must Have |
| **FR-061** | Centralized Navigation Sidebar | The admin layout shall provide an organized sidebar linking to all administrative modules: Causes, Programmes, Gallery, NGOs, Partners, Queries, Volunteers, and Donations. | Administrator | Must Have |
| **FR-062** | Recent Activity Feeds | The dashboard shall present quick-glance tables of recent donation events and latest contact queries. | Administrator | Should Have |
| **FR-063** | Role Access Restriction Handling | If a regular registered member attempts to access any `/Admin` URL directly, the system shall deny access with a 403 Forbidden message or redirect safely. | System / User | Must Have |
| **FR-064** | Confirmation Modals on Destructive Actions | All administrative deletion actions (e.g., deleting cause, removing partner, deleting gallery image) shall require explicit confirmation dialogs. | Administrator | Must Have |
| **FR-065** | Administrative User Management | Administrators shall be able to view registered member accounts and monitor system role memberships. | Administrator | Should Have |

---

## 3. Traceability to Academic Project Roadmap

The 65 functional requirements specified above comprehensively account for all operational tasks defined across:
- **Phase 3 (Public Website):** Tasks 08, 09, 10, 11, 12
- **Phase 4 (Backend Workflows):** Tasks 13, 14, 15
- **Phase 5 (Admin & Security):** Tasks 16, 17
