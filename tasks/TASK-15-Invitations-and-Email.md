# TASK-15 — Invite friends and email configuration

**Status:** Not Started  
**Dependencies:** Task 07  
**Estimated effort:** Estimate after checking your pace; do not treat this as a deadline.

## Objective

Provide a safe invitation workflow while keeping mail credentials out of source control.

## Steps

1. [ ] Create an invitation form that accepts a recipient email and optional short message.
2. [ ] Validate and rate-limit or otherwise protect the endpoint from obvious abuse.
3. [ ] Create a reusable email service and configuration abstraction.
4. [ ] Read credentials from safe configuration/user secrets/environment variables.
5. [ ] Record invitation status without storing unnecessary personal data.
6. [ ] If SMTP credentials are unavailable, test message composition and document how sending is configured; do not pretend an email was sent.

## Acceptance criteria

- [ ] Invalid email addresses are rejected.
- [ ] Secrets are not committed.
- [ ] Sending success/failure is handled and reported honestly.

## Expected outputs

- `Email service/configuration`
- `Invitation workflow`
- `Setup notes`

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
