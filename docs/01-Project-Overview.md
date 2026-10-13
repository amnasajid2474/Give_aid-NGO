# Give-AID — Project Overview and Objectives

**Document ID:** `DOC-01`  
**Project Name:** Give-AID — NGO Management & Donation Website  
**Author:** Software Engineering Student  
**Status:** Approved for Task 1 Requirements Baseline  
**Date:** October 2026  

---

## 1. Project Purpose

The **Give-AID NGO Management & Donation Website** is a centralized web platform engineered to connect non-governmental organizations (NGOs), community partners, volunteers, and benefactors. The platform enables non-profit initiatives to showcase their social welfare programmes, raise awareness for charitable causes, process simulated contributions securely, engage prospective volunteers, and address public inquiries through a structured administrative back-office.

---

## 2. Problem Statement

Many charitable institutions, community welfare bodies, and grassroots non-governmental organizations face persistent challenges in public outreach and operational management:

1. **Fragmented Outreach:** Information regarding current welfare programmes, organizational background, and partner affiliations is often scattered across disparate social media pages or offline pamphlets, resulting in low donor trust.
2. **Lack of Transparent Cause Tracking:** Potential donors struggle to understand where funds are targeted and lack immediate digital confirmation of their contributions.
3. **Manual Volunteer and Query Management:** Volunteer recruitment and public queries are frequently recorded in ad-hoc paper registries or unorganized email inboxes, leading to missed inquiries and volunteer disengagement.
4. **Administrative Overhead:** Non-profit coordinators lack a consolidated dashboard to monitor community interest, maintain event galleries, publish updates, and oversee donation activity.

---

## 3. Proposed Solution

The **Give-AID** web application addresses these challenges through a unified, accessible, and secure ASP.NET Core MVC web portal:

- **Public Awareness & Transparency:** A responsive, multi-page public portal showcasing the NGO's mission, team, causes, upcoming and past welfare programmes, verified partners, and photographic impact gallery.
- **Simulated Digital Giving:** A reliable donation pipeline allowing donors to select causes and make contributions via a deterministic, simulated payment workflow without storing or exposing sensitive payment credentials.
- **Community Participation:** Interactive mechanisms for community members to submit volunteer interest for upcoming welfare programmes and invite colleagues via email notifications.
- **Centralized Help & Communication:** A structured Help Centre, Frequently Asked Questions (FAQ) repository, and a direct inquiry workflow (`Contact Us`) with status tracking.
- **Role-Based Back-Office:** A dedicated, secured administrative dashboard providing authorized administrators with full CRUD (Create, Read, Update, Delete) capabilities over causes, programmes, partner organizations, gallery assets, and visitor queries.

---

## 4. Project Objectives

### 4.1 Academic & Technical Objectives
- Build a full-stack, enterprise-grade web application following the **ASP.NET Core Model-View-Controller (MVC)** architectural pattern.
- Implement object-relational mapping and data persistence using **Entity Framework Core (EF Core)** and **Microsoft SQL Server**.
- Enforce rigorous **Role-Based Access Control (RBAC)** leveraging **ASP.NET Core Identity**.
- Design clean, mobile-responsive interfaces complying with modern accessibility and usability principles using **Bootstrap 5**, **HTML5**, and **CSS3**.
- Maintain strict separation of concerns between presentation, business rules, data access, and view models.

### 4.2 Functional & Operational Objectives
- Allow unauthenticated visitors to explore organizational information, causes, welfare programmes, partner profiles, and help articles.
- Allow registered members to manage their profiles, track their personal donation history, view receipts, and register volunteer interest for programmes.
- Provide administrators with a protected back-office to maintain website content, inspect donations, moderate participation requests, and manage public queries.
- Ensure that zero actual financial credentials or credit card numbers are collected, transmitted, or persisted.

---

## 5. Target Users and Stakeholders

| Stakeholder / User Role | Description | Primary Needs / Use Cases |
| :--- | :--- | :--- |
| **Public Visitor (Guest)** | General public, potential benefactors, and prospective volunteers visiting the site. | Browse causes, read About Us sections, view gallery and programmes, access FAQ, submit contact inquiries, and make simulated donations. |
| **Registered Member / Donor** | Authenticated user who has created an account. | Log in securely, update profile, view personal donation history, view digital receipts, express volunteer interest in programmes, and invite friends. |
| **Administrator** | NGO staff or designated site administrator. | Manage causes, approve/track programmes, manage partners and NGOs, curate image gallery, respond to inquiries, review volunteer requests, and monitor overall donation totals. |
| **Academic Instructor / Evaluator** | Academic evaluation committee reviewing the software engineering eProject. | Review project architecture, documentation integrity, ER diagrams, testing logs, code maintainability, and functional verification. |

---

## 6. Technology Stack Specifications

- **Backend Framework:** ASP.NET Core MVC (C#)
- **Database Engine:** Microsoft SQL Server (LocalDB / SQL Express / Standard)
- **Object-Relational Mapper (ORM):** Entity Framework Core (EF Core) with Code-First Migrations
- **Authentication & Security:** ASP.NET Core Identity (PBKDF2 password hashing, Antiforgery validation)
- **Frontend & Styling:** Razor Views (.cshtml), HTML5, CSS3, JavaScript, Bootstrap 5
- **Development Environment:** Visual Studio on Microsoft Windows
- **Version Control & Repository:** Git & GitHub

---

## 7. Document Acceptance & Traceability

This document establishes the strategic baseline for **Task 1** of the Give-AID project. All subsequent functional specifications, entity models, and architectural layers derive from the goals established herein.
