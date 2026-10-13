# TASK-06 — SQL Server and Entity Framework Core

**Status:** Not Started  
**Dependencies:** Task 04  
**Estimated effort:** Estimate after checking your pace; do not treat this as a deadline.

## Objective

Connect the app to SQL Server using a maintainable data-access configuration.

## Steps

1. [ ] Choose the SQL Server instance/database name and record setup steps without recording secrets.
2. [ ] Add the EF Core SQL Server provider and design package versions compatible with the selected .NET target.
3. [ ] Create `Data/ApplicationDbContext.cs` and register the context in `Program.cs`.
4. [ ] Configure the connection string through development configuration or user secrets; keep production secrets out of source control.
5. [ ] Plan initial entities and relationships from the requirements before making migrations.
6. [ ] Add the first migration and apply it to the development database.
7. [ ] Confirm the database exists and the migration can be applied from a clean setup.

## Acceptance criteria

- [ ] The application starts with a valid database connection.
- [ ] EF Core migration applies successfully.
- [ ] Connection secrets are not committed.
- [ ] Entity/table design is recorded before adding all feature tables.

## Expected outputs

- ``Data/ApplicationDbContext.cs``
- ``docs/database-design.md``
- `EF Core migration files`

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
