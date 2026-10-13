# TASK-04 — Create and run the MVC project

**Status:** Completed (Awaiting User Sign-Off)  
**Dependencies:** Tasks 02 and 03  
**Estimated effort:** Completed

## Objective

Create the smallest working Give-AID ASP.NET Core MVC app before adding features.

## Steps

1. [x] Created the ASP.NET Core MVC application `GiveAid.Web` and solution `GiveAid.sln` / `GiveAid.slnx`.
2. [x] Configured target framework .NET 10 (`net10.0`) compatible with SDK 10.0.401.
3. [x] Used clean MVC skeleton without premature authentication packages (reserved for Task 7).
4. [x] Solution configured at workspace root referencing `GiveAid.Web/GiveAid.Web.csproj`.
5. [x] Executed build and smoke test: verified 0 errors, 0 warnings, and HTTP 200 response on `http://127.0.0.1:5000`.
6. [x] Inspected and documented generated controllers, views, wwwroot, Program.cs, and project structure in `docs/12-MVC-Project-Setup.md`.
7. [x] Documented execution instructions and architecture.

## Acceptance criteria

- [x] The project builds without errors (`0 Warning(s), 0 Error(s)`).
- [x] The local application starts and serves the Home and Privacy pages.
- [x] The solution and documentation are saved in the repository.

## Expected outputs

- `GiveAid.sln` & `GiveAid.slnx`
- `GiveAid.Web/`
- `docs/12-MVC-Project-Setup.md`

## Blocker log

- **Exact error / problem:** None.
- **What I was doing when it happened:** N/A
- **Last change made:** Completed build and smoke test on local server.
- **What I tried:** Tested GET request on port 5000 (`Invoke-WebRequest`).
- **Current result / next question:** All tests passed.

## Completion notes

- **Date completed:** October 13, 2026
- **Tests performed:** `dotnet build` succeeded; HTTP 200 returned for `/` and `/Home/Privacy`.
- **Evidence / screenshot path:** `docs/12-MVC-Project-Setup.md`
- **Git commit:** Pending user approval.
- **Follow-up work, if any:** Await user explicit approval before staging/committing and starting Task 5.
