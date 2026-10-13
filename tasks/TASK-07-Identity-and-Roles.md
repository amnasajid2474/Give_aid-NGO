# TASK-07 — Authentication and Admin/User roles

**Status:** Not Started  
**Dependencies:** Task 06  
**Estimated effort:** Estimate after checking your pace; do not treat this as a deadline.

## Objective

Use the framework's secure identity facilities instead of custom password handling.

## Steps

1. [ ] Add/configure ASP.NET Core Identity compatible with the project template and EF Core setup.
2. [ ] Define any required profile fields through a safe user model extension or separate profile model.
3. [ ] Create registration, login and logout flows with validation.
4. [ ] Configure `Admin` and `User` roles and a safe, repeatable way to seed the initial admin account.
5. [ ] Do not hard-code a production password; use local development secrets or a setup process.
6. [ ] Protect admin routes with authorization and role checks.
7. [ ] Verify unauthenticated visitors cannot access admin pages and regular users cannot perform admin actions.

## Acceptance criteria

- [ ] Register, login and logout work.
- [ ] Passwords are handled by Identity; no plaintext password is stored.
- [ ] Admin routes are restricted by role.
- [ ] A normal user cannot open admin-only actions.

## Expected outputs

- `Identity configuration`
- `Role seeding/setup notes`
- `Authentication views`

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
