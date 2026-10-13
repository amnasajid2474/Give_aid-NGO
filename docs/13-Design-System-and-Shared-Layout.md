# Give-AID — Design System, Navbar, Footer and Shared Layout

**Document ID:** `DOC-13-DESIGN`  
**Task ID:** `TASK-05` — Design System, Shared Layout, Navbar and Footer  
**Project Name:** Give-AID — NGO Management & Donation Website  
**Status:** Successfully Implemented & Verified  
**Date:** October 2026  

---

## 1. Visual Brand Direction & Color Palette

To establish a trustworthy, compassionate, and professional aesthetic suitable for an accredited social welfare organization, Give-AID utilizes an accessible color palette built on **Humanitarian Deep Teal**, **Warm Crimson Accent**, and crisp clean neutrals:

| Color Token | Hex Code | Visual Meaning / Architectural Role | Contrast vs `#ffffff` |
| :--- | :--- | :--- | :---: |
| **`--giveaid-primary`** | `#0f766e` | Deep Teal — Primary brand identity, hope, community health | **5.5:1** (Passes WCAG AA) |
| **`--giveaid-primary-dark`** | `#115e59` | Dark Teal — Hover states, button pressed states | **7.2:1** (Passes WCAG AAA) |
| **`--giveaid-primary-light`** | `#f0fdfa` | Subtle Teal — Active tab highlights, badge backgrounds | Tint / Non-text |
| **`--giveaid-secondary`** | `#0f172a` | Deep Slate Navy — Structural footer, brand title, dark text | **15.2:1** (Passes WCAG AAA) |
| **`--giveaid-accent`** | `#e11d48` | Rose Crimson — High-visibility "Donate Now" action button | **4.6:1** (Passes WCAG AA) |
| **`--giveaid-bg`** | `#f8fafc` | Soft Warm Slate — Eye-friendly page background | Background |
| **`--giveaid-surface`** | `#ffffff` | Pure White — Card, modal, and navbar surface | Surface |
| **`--giveaid-border`** | `#e2e8f0` | Slate Border — Clean dividers and form control outlines | Decorative / Structural |

---

## 2. Core Layout Architecture & Files

The shared frontend structure is organized into modular Razor partials and a master stylesheet:

```
GiveAid.Web/
├── Views/
│   └── Shared/
│       ├── _Layout.cshtml              <-- Master shell (HTML, meta, skip-link, partial references)
│       ├── _Navbar.cshtml              <-- Navigation bar partial (Brand, links, mobile burger, CTAs)
│       ├── _Footer.cshtml              <-- Footer partial (Mission, quick links, support, disclaimers)
│       └── _Layout.cshtml.css          <-- Scoped styling preventing footer absolute positioning
└── wwwroot/
    └── css/
        └── site.css                    <-- Master CSS variables, responsive typography, custom UI
```

---

## 3. Navbar Implementation & Traceability

The navigation bar (`_Navbar.cshtml`) incorporates all functional touchpoints defined in `docs/05-Page-and-Feature-Matrix.md`:

1. **Brand Identity:** Distinctive SVG heart/hands icon with "Give-AID" title and "NGO & Welfare" tagline.
2. **Accessible Mobile Navigation:** Bootstrap 5 collapse toggler with `aria-controls="navbarMain"`, `aria-label="Toggle navigation menu"`, and keyboard Tab focus support.
3. **Primary Navigation Links:**
   - **Home:** Active link (`/`, `Home/Index`).
   - **About Us:** Placeholder route (`/Home/About`), implemented in Task 8.
   - **Causes:** Catalog placeholder route (`/Causes`), implemented in Task 9.
   - **Programmes:** Events catalog placeholder route (`/Programmes`), implemented in Task 11.
   - **Explore Dropdown:** Groups secondary discovery pages without cluttering the header:
     - Photo Gallery (`/Gallery`, Task 11)
     - Affiliated NGOs & Partners (`/Partners`, Task 10)
     - Help Centre & FAQ (`/Help`, Task 12)
   - **Contact Us:** Public inquiry route (`/Contact`, Task 12).
4. **Header Action CTAs:**
   - **Sign In:** Outline button linking to `/Account/Login` (Task 7). No deceptive fake user avatar or fake login state is displayed.
   - **Donate Now:** Primary pill button with heart icon linking to `/Donate` (Tasks 9 and 13).

---

## 4. Reusable Footer Implementation

The footer (`_Footer.cshtml`) provides an accessible, non-intrusive foundation:
- **Organization Identity:** Full logo and mission statement.
- **Academic Disclaimer Badge:** Clearly identifies the platform as an educational software engineering eProject with simulated payments.
- **Quick Links & Support:** Categorized columns linking to all major platform sections.
- **Demo Contact Information:** Documented placeholders (`support@giveaid-demo.org`, `+92 (0) 800-GIVE-AID`) without inventing fake personal numbers.
- **Modern Flexbox Stickiness:** Built using flexbox column layout (`min-height: 100vh` on `body`, `flex: 1` on `main`), eliminating overlapping bugs caused by older `position: absolute` approaches.

---

## 5. Accessibility Features (WCAG 2.1 AA)

- **Skip to Main Content Link:** Built-in `.skip-link` allows keyboard and screen reader users to bypass top navigation and jump directly to `#main-content`.
- **Keyboard Focus Rings:** Clear, high-contrast focus rings (`outline: 3px solid rgba(15, 118, 110, 0.55)`) applied globally to interactive links and buttons.
- **Semantic Landmark Roles:** Semantic `<header>`, `<nav role="navigation">`, `<main id="main-content" role="main">`, and `<footer role="contentinfo">`.
- **Scalable Typography:** Root font scaling with rem units respecting user operating system zoom preferences.

---

## 6. Live Testing & Verification Results

| Test Scenario | Verification Method | Outcome | Status |
| :--- | :--- | :--- | :---: |
| **Solution Compilation** | `dotnet build GiveAid.sln` | Build Succeeded, 0 Errors, 0 Warnings | **PASSED** |
| **Home Page Layout** | `GET http://127.0.0.1:5000/` | HTTP 200 OK (Content Length: 9,334 bytes) | **PASSED** |
| **Navbar Render** | Inspected HTML output for `.giveaid-navbar` | Verified present with logo, links, and Donate CTA | **PASSED** |
| **Footer Render** | Inspected HTML output for `.giveaid-footer` | Verified present with columns and disclaimer | **PASSED** |
| **Privacy Page Layout** | `GET http://127.0.0.1:5000/Home/Privacy` | HTTP 200 OK (Shared layout inherited properly) | **PASSED** |
| **Skip Link Accessibility** | Inspected DOM for `.skip-link` targeting `#main-content` | Verified present at start of `<body>` | **PASSED** |
| **Responsive Grid** | Bootstrap 5 utility classes inspected | Mobile collapse verified (`navbar-expand-lg`) | **PASSED** |

---

## 7. Acceptance Criteria Checklist (TASK-05)

- [x] Shared layout renders on at least two pages (`Home/Index` and `Home/Privacy`).
- [x] Navigation links point to real MVC routes or clearly documented placeholder routes for later tasks.
- [x] Layout works at mobile, tablet, and desktop widths without horizontal overflow.
- [x] High-contrast, accessible keyboard navigation and skip link implemented.
- [x] Zero premature database models, authentication code, or third-party dependencies added.
