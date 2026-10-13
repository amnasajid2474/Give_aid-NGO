# TASK-05 — Design system and shared layout

**Status:** Completed (Awaiting User Sign-Off)  
**Dependencies:** Task 04  
**Estimated effort:** Completed

## Objective

Create a consistent, accessible visual shell that all pages can reuse.

## Steps

1. [x] Formulated compassionate, trustworthy humanitarian color palette (Deep Teal `#0f766e`, Slate Navy `#0f172a`, Rose Crimson `#e11d48`).
2. [x] Updated master Razor layout `Views/Shared/_Layout.cshtml` with accessible skip-link and responsive structure.
3. [x] Built modular navigation partial `Views/Shared/_Navbar.cshtml` with brand logo, links, Explore dropdown, Sign In, and Donate CTA.
4. [x] Built modular footer partial `Views/Shared/_Footer.cshtml` with organization summary, quick links, support, and demo disclaimer.
5. [x] Implemented responsive design system in `wwwroot/css/site.css` with CSS variables, focus rings, and card styling.
6. [x] Added WCAG 2.1 AA keyboard accessibility, focus rings, and screen-reader skip-link.
7. [x] Cleaned scoped `_Layout.cshtml.css` to ensure full flexbox sticky-footer compatibility.

## Acceptance criteria

- [x] Shared layout renders on at least two pages (`Home/Index` and `Home/Privacy`).
- [x] Navigation links point to real MVC routes or clearly marked upcoming routes.
- [x] Layout works at mobile and desktop widths without horizontal overflow.

## Expected outputs

- `Views/Shared/_Layout.cshtml`
- `Views/Shared/_Navbar.cshtml`
- `Views/Shared/_Footer.cshtml`
- `wwwroot/css/site.css`
- `docs/13-Design-System-and-Shared-Layout.md`

## Blocker log

- **Exact error / problem:** None.
- **What I was doing when it happened:** N/A
- **Last change made:** Created layout partials, master stylesheet, and documentation.
- **What I tried:** Tested live rendering on `http://127.0.0.1:5000` for both `/` and `/Home/Privacy`.
- **Current result / next question:** HTTP 200 OK verified on all pages with navbar and footer intact.

## Completion notes

- **Date completed:** October 13, 2026
- **Tests performed:** Automated HTTP GET request verified presence of `.giveaid-navbar`, `.giveaid-footer`, `.skip-link`, and correct layout inheritance.
- **Evidence / screenshot path:** `docs/13-Design-System-and-Shared-Layout.md`
- **Git commit:** Pending user approval.
- **Follow-up work, if any:** Await user explicit approval to commit/push and begin Task 6.
