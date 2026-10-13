# Give-AID — Backup Routine Summary

**Document ID:** `DOC-BKP`  
**Task ID:** `TASK-03` — Git, GitHub and Project Backup  
**Date:** October 2026  

---

## Standard Backup Protocol

1. **Local Version Control Checkpoint:**
   - Commit changes after every completed roadmap task using:
     ```powershell
     git add .
     git commit -m "task-xx: completed task title"
     ```
2. **Cloud Remote Backup (GitHub Private Repository):**
   - Push completed milestones to GitHub:
     ```powershell
     git push origin main
     ```
3. **Weekly Offline ZIP Archive:**
   - Create a clean `.zip` archive of `d:\Give-AID NGO` (excluding `bin/`, `obj/`, and `.vs/`) and store it on an external USB flash drive or secondary drive partition before major milestones.

Full details: [10-Git-and-Backup-Guide.md](file:///d:/Give-AID%20NGO/docs/10-Git-and-Backup-Guide.md)
