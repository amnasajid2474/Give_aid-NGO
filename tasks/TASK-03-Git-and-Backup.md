# TASK-03 — Git repository and backup routine

**Status:** In Progress (Awaiting User Sign-Off for git init & Initial Commit)  
**Dependencies:** Task 01  
**Estimated effort:** In Progress

## Objective

Protect project work from accidental loss and keep changes traceable.

## Steps

1. [x] Inspected workspace: Git v2.54.0.windows.1 confirmed, repository not yet initialized.
2. [x] Created comprehensive `.gitignore` for Visual Studio, .NET build artifacts, EF Core, SQL Server, and secrets.
3. [x] Ensured secrets, local database binaries, and temporary files are strictly excluded.
4. [x] Documented version control workflow and multi-tier backup routines in `docs/10-Git-and-Backup-Guide.md` and `docs/backup-routine.md`.
5. [ ] Execute `git init` and create initial checkpoint commit (Awaiting user explicit approval).

## Acceptance criteria

- [x] Workspace inspected with read-only commands (`git --version`, `git status`).
- [x] `.gitignore` created and protects against accidental secrets or build artifact tracking.
- [x] Multi-tier backup routine documented (`docs/10-Git-and-Backup-Guide.md`, `docs/backup-routine.md`).
- [ ] Initial commit created and verified with `git log` (Pending approval).

## Expected outputs

- `.gitignore`
- `docs/10-Git-and-Backup-Guide.md`
- `docs/11-Git-Checkpoint-Log.md`
- `docs/backup-routine.md`

## Blocker log

- **Exact error / problem:** None.
- **What I was doing when it happened:** N/A
- **Last change made:** Created `.gitignore` and Git documentation suite.
- **What I tried:** Verified Git version and global user identity (`Amna Sajid`).
- **Current result / next question:** Awaiting user approval to run `git init` and commit.

## Completion notes

- **Date completed:** In progress (October 13, 2026)
- **Tests performed:** Git binary verified, global config verified, `.gitignore` created.
- **Evidence / screenshot path:** `docs/10-Git-and-Backup-Guide.md`, `docs/11-Git-Checkpoint-Log.md`
- **Git commit:** Awaiting user approval to execute initial commit.
- **Follow-up work, if any:** Initialize repo, commit, and proceed to Task 4 once approved.
