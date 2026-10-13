# Task Index — Give-AID NGO Website

Use this index as the task queue. Work in order unless a task explicitly depends on a previous task.

## Status key
- **Not Started** — not begun.
- **In Progress** — currently being worked on.
- **Blocked** — cannot continue; record the exact issue and what was tried.
- **Done** — acceptance criteria passed and evidence recorded.

## Tasks

| ID | Task file | Goal | Depends on |
|---|---|---|---|
| 01 | `TASK-01-Requirements-and-Scope.md` | Confirm requirements and boundaries | None |
| 02 | `TASK-02-Tools-and-Environment.md` | Verify Visual Studio, .NET SDK and SQL Server | 01 |
| 03 | `TASK-03-Git-and-Backup.md` | Create repository and backup routine | 01 |
| 04 | `TASK-04-Create-MVC-Project.md` | Create and run MVC app | 02, 03 |
| 05 | `TASK-05-Design-System-and-Layout.md` | Establish styles, navbar, footer and responsive layout | 04 |
| 06 | `TASK-06-Database-and-EF-Core.md` | Configure SQL Server and EF Core | 04 |
| 07 | `TASK-07-Identity-and-Roles.md` | Add authentication and Admin/User roles | 06 |
| 08 | `TASK-08-Home-and-Public-Content.md` | Build Home and About pages | 05 |
| 09 | `TASK-09-Causes-and-Donation-Public-UI.md` | Build cause and donation screens | 05 |
| 10 | `TASK-10-NGO-and-Partner-Management.md` | NGO and partner listing/admin CRUD | 06, 07 |
| 11 | `TASK-11-Programmes-and-Gallery.md` | Programme and gallery workflows | 06, 07 |
| 12 | `TASK-12-Help-Contact-and-Queries.md` | Help Centre, Contact and admin replies | 06, 07 |
| 13 | `TASK-13-Donation-Workflow.md` | Validated simulated donations and history | 07, 09 |
| 14 | `TASK-14-Programme-Interest.md` | User interest submissions and admin review | 11 |
| 15 | `TASK-15-Invitations-and-Email.md` | Invite-friends email workflow | 07 |
| 16 | `TASK-16-Admin-Dashboard.md` | Combine admin navigation and summaries | 07, 10, 11, 12, 13, 14 |
| 17 | `TASK-17-Validation-Security-and-Errors.md` | Harden validation, access and error handling | 07–16 |
| 18 | `TASK-18-Testing-and-Bug-Fixes.md` | Run end-to-end and regression checks | 08–17 |
| 19 | `TASK-19-Documentation-and-Diagrams.md` | Prepare eProject documentation | 01–18 |
| 20 | `TASK-20-Final-Backup-and-Submission.md` | Verify backup and submission package | 18, 19 |

## Before you start a task
1. Read its objective, dependencies and steps.
2. Change status to **In Progress**.
3. Do only the work described by the task.
4. Run every verification step.
5. Record results and any evidence.
6. Mark **Done** only after acceptance criteria pass.

If an issue blocks you, leave the task **Blocked** and record the exact error, the last change made, and the troubleshooting attempts. Do not skip it silently.
