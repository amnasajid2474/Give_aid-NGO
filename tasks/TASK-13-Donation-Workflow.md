# TASK-13 — Simulated donation workflow and history

**Status:** Not Started  
**Dependencies:** Tasks 07 and 09  
**Estimated effort:** Estimate after checking your pace; do not treat this as a deadline.

## Objective

Complete a safe, testable donation journey with a dummy payment outcome.

## Steps

1. [ ] Create/confirm Donation model with user, cause, amount, reference, status and timestamps.
2. [ ] Validate amount on the server and confirm the selected cause exists and is active.
3. [ ] Implement a clearly labelled simulated payment step with deterministic success/failure outcomes for testing.
4. [ ] Never store real card number, CVV, PIN or actual payment credentials; do not claim a real transaction occurred.
5. [ ] Save donation result/status and a non-sensitive reference in SQL Server.
6. [ ] Build a confirmation/receipt view and a history page limited to the signed-in user's own donations.
7. [ ] Build an admin view for donation records and status.

## Acceptance criteria

- [ ] Valid demo donations are recorded with the correct user and cause.
- [ ] Invalid amounts and unavailable causes are rejected.
- [ ] A user cannot view another user's donation history.
- [ ] No sensitive card data is logged or stored.

## Expected outputs

- `Donation model and migration`
- `Donation service/controller`
- `History/receipt views`

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
