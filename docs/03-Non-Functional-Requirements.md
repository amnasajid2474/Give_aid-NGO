# Give-AID — Non-Functional Requirements Specification

**Document ID:** `DOC-03`  
**Project Name:** Give-AID — NGO Management & Donation Website  
**Status:** Approved for Task 1 Requirements Baseline  
**Date:** October 2026  

---

## 1. Overview of Non-Functional Requirements

Non-functional requirements (NFRs) specify the quality attributes, architectural constraints, security controls, and performance criteria that the Give-AID platform must adhere to. Every requirement is assigned a unique identifier (`NFR-xxx`).

---

## 2. Requirements Catalog

### Category 1: Security & Identity

| Requirement ID | Quality Category | Requirement Specification |
| :--- | :--- | :--- |
| **NFR-001** | Password Protection | User passwords must never be stored in plaintext. Passwords must be hashed and salted using ASP.NET Core Identity's default PBKDF2 with HMAC-SHA256 and high work-factor iterations. |
| **NFR-002** | Anti-Cross-Site Request Forgery (CSRF) | All HTTP POST, PUT, and DELETE form submissions must enforce ASP.NET Core Antiforgery Token validation (`[ValidateAntiForgeryToken]`). |
| **NFR-003** | Server-Side Role Enforcement | Access control to administrative controllers and endpoints must be validated strictly on the server using `[Authorize(Roles = "Admin")]`. Hiding client-side buttons alone is considered insufficient. |
| **NFR-004** | Protection Against Cross-Site Scripting (XSS) | All dynamic output rendered via Razor views must undergo automatic contextual HTML encoding (`@Model.Property`). Raw HTML output (`@Html.Raw`) is forbidden unless explicitly sanitized. |
| **NFR-005** | Protection Against SQL Injection | All data access queries must utilize Entity Framework Core parameterized LINQ queries. Raw SQL string concatenation is strictly prohibited. |
| **NFR-006** | Secure Cookie Configuration | Authentication cookies must be flagged with `HttpOnly`, `SameSite = SameSiteMode.Lax` or `Strict`, and `Secure` policy in production and HTTPS development. |
| **NFR-007** | Secrets Management | Database credentials, administrative seeds, and API keys must never be committed into Git repositories. Configuration must leverage `appsettings.Development.json` (gitignored), User Secrets (`dotnet user-secrets`), or Environment Variables. |

---

### Category 2: Privacy & Financial Safety

| Requirement ID | Quality Category | Requirement Specification |
| :--- | :--- | :--- |
| **NFR-008** | Zero Storage of Financial Credentials | Under no circumstances shall real or full payment card numbers (PAN), CVV/CVC codes, card expiration dates, or bank PINs be stored in the database, session variables, or diagnostic logs. |
| **NFR-009** | Deterministic Payment Simulation | The donation flow must be clearly labeled as a "Simulated Demonstration". Simulated transactions must generate non-sensitive dummy reference codes (e.g., `REF-DEMO-20261013-XXXX`). |
| **NFR-010** | Data Segregation & Privacy | Authenticated users must only be permitted to view their own personal donation histories, profile data, and inquiry submissions. Cross-tenant access must be blocked by validating `User.Identity.Name` or user ID at the query level. |

---

### Category 3: Server-Side Validation & Input Sanitization

| Requirement ID | Quality Category | Requirement Specification |
| :--- | :--- | :--- |
| **NFR-011** | Mandatory Server Validation | All incoming user data must be validated on the server using strongly-typed ViewModels and `System.ComponentModel.DataAnnotations` (e.g., `[Required]`, `[StringLength]`, `[Range]`, `[EmailAddress]`). Client-side validation is deemed supplementary only. |
| **NFR-012** | Model State Verification | Controllers must verify `ModelState.IsValid` before executing business logic or persisting data, returning informative validation messages when errors occur. |
| **NFR-013** | File Upload Sanitization | File uploads (logos, gallery images, cause photos) must be validated for allowed file extensions (`.jpg`, `.jpeg`, `.png`, `.webp`), MIME types, and file size limits (max 2MB - 5MB). Files must be saved with cryptographically random filenames (e.g., GUIDs) to prevent path traversal attacks. |

---

### Category 4: Usability, Responsive Design & Accessibility

| Requirement ID | Quality Category | Requirement Specification |
| :--- | :--- | :--- |
| **NFR-014** | Responsive Viewport Adaptation | The user interface must be fully responsive across mobile screens (min 360px), tablets (768px), and desktops (1024px+), avoiding horizontal scrollbars. |
| **NFR-015** | Mobile First CSS Grid | Styling must be built utilizing Bootstrap 5 responsive utility classes and custom semantic stylesheets with a cohesive charity-themed visual hierarchy. |
| **NFR-016** | Visual Accessibility (WCAG 2.1 AA) | Text and interactive elements must satisfy WCAG 2.1 AA minimum contrast ratios (4.5:1 for body text, 3:1 for large headers). All images must feature meaningful `alt` attributes. |
| **NFR-017** | Keyboard & Screen Reader Accessibility | All interactive buttons, forms, links, and modal dialogs must be navigable using keyboard tab sequences with clearly visible focus rings. |

---

### Category 5: Reliability, Performance & Maintainability

| Requirement ID | Quality Category | Requirement Specification |
| :--- | :--- | :--- |
| **NFR-018** | Relational Data Integrity | Database schemas managed via EF Core must enforce referential integrity using explicit Foreign Key constraints, appropriate cascading/restrictive delete rules, and non-nullable keys. |
| **NFR-019** | Asynchronous Operations | All database input/output, file saving, and network operations must utilize C# asynchronous programming (`async` and `await`, `ToListAsync()`, `SaveChangesAsync()`) to ensure optimal thread pool utilization. |
| **NFR-020** | Clean Architectural Separation | Code must strictly adhere to the MVC design pattern, cleanly segregating ViewModels (`Models/ViewModels/`), Domain Entities (`Models/`), Views (`Views/`), Controllers (`Controllers/`), and Data Access (`Data/`). |
| **NFR-021** | Code Clarity & Documentation | Code must maintain clean naming conventions, avoid duplicated logic, incorporate beginner-friendly code comments, and preserve complete docstrings. |

---

### Category 6: Error Handling & Diagnostics

| Requirement ID | Quality Category | Requirement Specification |
| :--- | :--- | :--- |
| **NFR-022** | Production Error Pages | In non-development environments, unhandled exceptions must redirect to a friendly, branded custom error page (`/Home/Error` or `/Error/500`). Detailed stack traces and configuration secrets must never be exposed to end users. |
| **NFR-023** | HTTP 404 Not Found Handling | Requests to nonexistent routes or deleted records must render a user-friendly 404 page featuring navigational recovery links back to the Home page. |
| **NFR-024** | Diagnostic Logging | Application errors must be recorded using ASP.NET Core `ILogger` with appropriate log severity levels (`Information`, `Warning`, `Error`) without logging sensitive user passwords. |

---

### Category 7: Verification & Academic Traceability

| Requirement ID | Quality Category | Requirement Specification |
| :--- | :--- | :--- |
| **NFR-025** | End-to-End Testability | Every critical user workflow (registration, donation simulation, gallery browsing, admin CRUD, contact query submission) must be manually testable with documented expected and actual results. |
| **NFR-026** | Reproducible Deployment | The application must be runnable on another Windows workstation running Visual Studio and SQL Server LocalDB/Express simply by applying EF Core migrations. |
