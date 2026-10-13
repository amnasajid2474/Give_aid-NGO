# TASK-03 — Git repository and backup routine

**Status:** Completed (Committed & Synced to GitHub)  
**Dependencies:** Task 01  
**Estimated effort:** Completed

## Objective

Protect project work from accidental loss and keep changes traceable.

## Steps

1. [x] Inspected workspace: Git v2.54.0.windows.1 confirmed, repository initialized.
2. [x] Created comprehensive `.gitignore` for Visual Studio, .NET build artifacts, EF Core, SQL Server, and secrets.
3. [x] Ensured secrets, local database binaries, and temporary files are strictly excluded.
4. [x] Documented version control workflow and multi-tier backup routines in `docs/10-Git-and-Backup-Guide.md` and `docs/backup-routine.md`.
5. [x] Executed `git init`, set branch to `main`, and committed baseline (`a64a145`).
6. [x] Linked remote `https://github.com/amnasajid2474/Give_aid-NGO.git` and pushed `main` branch.

## Acceptance criteria

- [x] Workspace inspected with read-only commands (`git --version`, `git status`).
- [x] `.gitignore` created and protects against accidental secrets or build artifact tracking.
- [x] Multi-tier backup routine documented (`docs/10-Git-and-Backup-Guide.md`, `docs/backup-routine.md`).
- [x] Initial commit created (`a64a145`) and verified with `git log`.
- [x] Remote repository connected and synced to GitHub (`origin/main`).

## Expected outputs

- `.gitignore`
- `docs/10-Git-and-Backup-Guide.md`
- `docs/11-Git-Checkpoint-Log.md`
- `docs/backup-routine.md`

## Blocker log

- **Exact error / problem:** None.
- **What I was doing when it happened:** N/A
- **Last change made:** Pushed initial commit `a64a145` to GitHub.
- **What I tried:** `git push -u origin main`.
- **Current result / next question:** Remote repository synced cleanly.

## Completion notes

- **Date completed:** October 13, 2026
- **Tests performed:** `git status` clean, `git log -1` verified commit `a64a145`, `git push` succeeded.
- **Evidence / screenshot path:** `docs/10-Git-and-Backup-Guide.md`, `docs/11-Git-Checkpoint-Log.md`
- **Git commit:** `a64a145` pushed to `https://github.com/amnasajid2474/Give_aid-NGO.git`
- **Follow-up work, if any:** Proceed to Phase 2, Task 4 (Create ASP.NET Core MVC Project) upon user approval.
