# TASK-02 — Tools and environment check

**Status:** Completed (Awaiting User Sign-Off)  
**Dependencies:** Task 01  
**Estimated effort:** Completed

## Objective

Verify that the development tools needed for a modern ASP.NET Core MVC application are installed.

## Steps

1. [x] Verified Visual Studio Community 2026 and confirmed the `Microsoft.VisualStudio.Workload.NetWeb` workload is installed.
2. [x] Ran `dotnet --info` and `dotnet --list-sdks`; recorded .NET SDK 10.0.401 and runtime 10.0.12.
3. [x] Confirmed Microsoft SQL Server Express is installed, running as Windows service (`MSSQL$SQLEXPRESS`), and tested connection successfully (`Server=.\SQLEXPRESS`).
4. [x] Confirmed SQL Server Management Studio 22 (v22.5.2) is installed.
5. [x] Selected .NET SDK framework compatible with Visual Studio and runtime.
6. [x] Recorded versions and tooling in `docs/08-Environment-Requirements.md`, `docs/09-Environment-Verification.md`, and `docs/environment.md`.

## Acceptance criteria

- [x] `dotnet --info` runs successfully.
- [x] Visual Studio can create an ASP.NET Core MVC project (`NetWeb` workload confirmed).
- [x] A SQL Server instance is available and verified reachable via Windows Authentication.

## Expected outputs

- `docs/08-Environment-Requirements.md`
- `docs/09-Environment-Verification.md`
- `docs/environment.md`

## Blocker log

- **Exact error / problem:** None. All tools verified.
- **What I was doing when it happened:** N/A
- **Last change made:** Ran read-only checks for VS, dotnet, SQL, SSMS, Git.
- **What I tried:** Tested SQL connectivity directly to `.\SQLEXPRESS`.
- **Current result / next question:** Environment is 100% ready. No installations required.

## Completion notes

- **Date completed:** October 13, 2026
- **Tests performed:** Live diagnostics via `vswhere.exe`, `dotnet --info`, `Get-Service *SQL*`, and `SqlConnection` handshake.
- **Evidence / screenshot path:** `docs/09-Environment-Verification.md`
- **Git commit:** Pending Task 3.
- **Follow-up work, if any:** Await user explicit approval before starting Task 3.
