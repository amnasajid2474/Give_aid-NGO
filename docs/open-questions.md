# Give-AID — Open Questions & Technical Assumptions Log

**Document ID:** `DOC-08`  
**Task ID:** `TASK-01` — Requirements Analysis and Project Scope  
**Status:** Active Tracking  
**Date:** October 2026  

---

## 1. Overview

This document records technical assumptions, items requiring confirmation with the academic instructor/supervisor, and decisions made during the initial requirements analysis phase.

---

## 2. Missing Documents Log

1. **`NGO-website.doc` / `Project Specification - NGO.DOC`:**
   - **Current State:** The files were not present in the workspace root or common user directories.
   - **Handling Strategy:** We have derived all core functional and non-functional requirements from the comprehensive task files (`tasks/TASK-00-README.md` to `tasks/TASK-20-Final-Backup-and-Submission.md`) which directly encode the eProject requirements.
   - **Action Item:** If the instructor provides an updated copy of `NGO-website.doc`, any additional specific constraints will be merged into `docs/02-Functional-Requirements.md`.

2. **`plan.md`:**
   - **Current State:** Mentioned in `README.md`, but not present.
   - **Handling Strategy:** Formalized and superseded by the comprehensive documentation in `docs/` (`01-Project-Overview.md` through `07-Task-01-Acceptance-Checklist.md`).

---

## 3. Technical Assumptions

1. **Simulated Payment Gateway:**
   - **Assumption:** No live merchant credentials (Stripe/PayPal) are required. The donation process will use a deterministic simulation (mock test card numbers that predictably produce "Success" or "Failed" outcomes).
   - **Justification:** Avoids legal, PCI-DSS compliance, and financial liability issues for a student eProject while providing full end-to-end user experience and receipt generation.

2. **Single Currency:**
   - **Assumption:** All financial targets, donation amounts, and impact stats are handled in a single standard currency (default: PKR or USD).
   - **Justification:** Multi-currency forex conversion adds unnecessary external API dependencies without adding core software engineering value.

3. **Email Protocol:**
   - **Assumption:** An `IEmailSender` abstraction will be configured. During local development, outgoing invitations and query acknowledgments will be written to local diagnostic logs or a debug file rather than crashing if SMTP credentials are not configured.
   - **Justification:** Prevents hardcoding secrets in Git repositories.

4. **Media Storage:**
   - **Assumption:** Uploaded logos and photos will be stored on local web disk (`wwwroot/uploads/`) with sanitized GUID filenames, storing the relative URI in the database.
   - **Justification:** Reliable, self-contained for local academic evaluation, and requires no external paid cloud storage (like AWS S3).

---

## 4. Open Questions for Instructor Clarification

| # | Question | Default Proposal | Status |
| :-: | :--- | :--- | :---: |
| **Q1** | What is the minimum target .NET version accepted for submission? | .NET 8.0 LTS (Long Term Support). | Open |
| **Q2** | Should the "Invite Friends" feature send real SMTP emails or is development console logging sufficient? | Mock email service with clean logging abstraction to protect credentials. | Open |
| **Q3** | Is guest donation required, or must every donor register an account first? | Support both: allow guest donation with email input, and link automatically if logged in. | Resolved (`FR-021`) |
