# TASK-17 — Validation, security and error handling

**Status:** Not Started  
**Dependencies:** Tasks 07–16  
**Estimated effort:** Estimate after checking your pace; do not treat this as a deadline.

## Objective

Review common security and reliability risks across the application.

## Steps

1. [ ] Use server-side validation for all state-changing forms; client-side validation is supplementary.
2. [ ] Use antiforgery protection for form posts and follow MVC/Identity defaults.
3. [ ] Verify authorization in controllers/actions, not just by hiding buttons.
4. [ ] Review file uploads, generated filenames, file size/type limits and storage paths.
5. [ ] Ensure users can only view/edit their own profile, donation history and submissions.
6. [ ] Add friendly not-found and error pages; avoid showing stack traces or secrets to end users.
7. [ ] Move secrets out of tracked configuration files.
8. [ ] Check output encoding, query usage and deletion confirmations.
9. [ ] Review accessibility basics: labels, focus, contrast, alt text and keyboard navigation.

## Acceptance criteria

- [ ] Security checklist passes for public, user and admin routes.
- [ ] No secrets or sensitive card information are stored in the repository/database/logs.
- [ ] Errors are user-friendly and diagnostic details remain in development logs.

## Expected outputs

- ``docs/security-review.md``
- `Updated validation/error handling`

## Blocker log

- **Exact error / problem:**
- **What I was doing when it happened:**
- **Last change made:**
- **What I tried:**
- **Current result / next question:**

## Completion notes

- **Date completed:**
- **Tests performed:**
- **Evidence / screenshot path:**
- **Git commit:**
- **Follow-up work, if any:**
