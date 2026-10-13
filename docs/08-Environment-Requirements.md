# Give-AID — Development Environment & Tooling Requirements

**Document ID:** `DOC-08-REQ`  
**Task ID:** `TASK-02` — Tools and Development Environment Setup  
**Project Name:** Give-AID — NGO Management & Donation Website  
**Status:** Approved Environment Baseline  
**Date:** October 2026  

---

## 1. Overview

To develop, compile, test, and host the Give-AID NGO Management and Donation web application, a modern, robust Microsoft Windows development ecosystem is required. This document details the mandatory tools, recommended versions, compatibility matrix, and the fundamental distinctions between database engine components.

---

## 2. Mandatory Development Toolchain

| Tool / Technology | Minimum Version | Recommended Version | Primary Role in Give-AID Project | Official Source |
| :--- | :--- | :--- | :--- | :--- |
| **Microsoft Visual Studio** | VS 2022 (v17.8+) | VS Community 2026 (v18.10+) | Full-featured Integrated Development Environment (IDE) with C# IntelliSense, Razor tooling, debugger, and NuGet package manager. | [visualstudio.microsoft.com](https://visualstudio.microsoft.com/) |
| **ASP.NET & Web Workload** | Workload `NetWeb` | `Microsoft.VisualStudio.Workload.NetWeb` | Core Visual Studio components for ASP.NET Core MVC, Razor pages, Web APIs, and IIS Express/Kestrel hosting. | VS Installer |
| **.NET SDK & Runtime** | .NET 8.0 LTS | .NET 10.0 SDK (v10.0.401+) | Compiles C# source code, provides CLI commands (`dotnet build`, `dotnet run`), and hosts the ASP.NET Core runtime. | [dotnet.microsoft.com](https://dotnet.microsoft.com/download) |
| **SQL Server Database Engine** | SQL Server 2019 | SQL Server 2025/2026 Express (`.\SQLEXPRESS`) | Relational database management system (RDBMS) that stores tables, indexes, user logins, causes, and transactions. | [microsoft.com/sql-server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) |
| **SQL Server Management Studio (SSMS)** | SSMS v19.x | SSMS v22.x | Graphical User Interface (GUI) client application used to inspect database tables, execute SQL queries, and manage database security. | [aka.ms/ssmsfullsetup](https://aka.ms/ssmsfullsetup) |
| **Git Version Control** | Git 2.40+ | Git 2.54+ | Distributed version control system for tracking code changes, committing milestones, and enabling rollback capabilities. | [git-scm.com](https://git-scm.com/) |
| **Modern Web Browser** | Chromium / Firefox | Microsoft Edge / Google Chrome | Web browser with Developer Tools (F12) for verifying HTML5 responsiveness, CSS layout, and JavaScript execution. | Pre-installed |

---

## 3. Critical Technical Distinction: SQL Server Components

A frequent point of confusion for beginners is the difference between the **Database Engine**, **LocalDB**, and **SSMS**.

```
+-----------------------------------------------------------------------------------+
|                           CLIENT / MANAGEMENT LAYER                               |
|                                                                                   |
|    +----------------------------------+    +---------------------------------+    |
|    | SQL Server Management Studio     |    | Visual Studio / EF Core App     |    |
|    | (SSMS) — GUI Tool Only           |    | (GiveAidNGO Web Application)    |    |
|    +----------------------------------+    +---------------------------------+    |
+-----------------------------------------|-----------------------------------------+
                                          | Network / Named Pipes Protocol
+-----------------------------------------v-----------------------------------------+
|                         DATABASE SERVER / ENGINE LAYER                            |
|                                                                                   |
|    Option A: Dedicated Service               Option B: Developer Instance         |
|    +----------------------------------+      +-------------------------------+    |
|    | SQL Server Express               |      | SQL Server LocalDB            |    |
|    | Instance: .\SQLEXPRESS           |  OR  | Instance: (localdb)\MSSQLLocalDB|  |
|    | Runs continuously as a Windows   |      | Runs on-demand for developer  |    |
|    | background service (sqlservr.exe)|      | processes only                |    |
|    +----------------------------------+      +-------------------------------+    |
|                                                                                   |
|                                [ PHYSICAL STORAGE ]                               |
|                       .mdf (Data File)  |  .ldf (Log File)                        |
+-----------------------------------------------------------------------------------+
```

### 3.1 SQL Server Database Engine (The Server)
- **What it is:** The actual backend database engine process (`sqlservr.exe`) that executes SQL queries, maintains relational integrity, writes to physical `.mdf`/`.ldf` storage files, and listens for database connections.
- **Key Insight:** Without this engine running, no application can connect or store data, regardless of what GUI tools are installed.
- **Give-AID Setup:** On your machine, **SQL Server Express** is installed and actively running as a background Windows Service (`MSSQL$SQLEXPRESS`).

### 3.2 SQL Server Management Studio (SSMS) (The Client GUI)
- **What it is:** A desktop administrative client application. Think of SSMS like a web browser: a browser lets you view websites, but it is not the web server. Similarly, SSMS lets you view, query, and edit SQL Server databases, but **installing SSMS does not install a database engine**.
- **Give-AID Setup:** SSMS 22 is installed on your machine and connects directly to `.\SQLEXPRESS`.

### 3.3 SQL Server Express vs. LocalDB
- **SQL Server Express (`.\SQLEXPRESS`):** A free, full-featured edition of Microsoft SQL Server designed for small to medium applications. It runs continuously as a Windows Service, supports Windows Authentication, and is the standard industry choice for development and deployment.
- **SQL Server LocalDB (`(localdb)\MSSQLLocalDB`):** A lightweight developer execution mode of SQL Server Express that only spins up when an application connects and shuts down when idle.
- **Recommendation for Give-AID:** We recommend using the already-running **SQL Server Express (`Server=.\SQLEXPRESS;Integrated Security=True;TrustServerCertificate=True`)**. It is robust, permanent, and easily inspectable in SSMS.

---

## 4. Entity Framework Core Tooling Considerations

Entity Framework Core utilizes two primary methods for generating migrations and updating databases:

1. **Visual Studio Package Manager Console (PMC):**
   - Commands: `Add-Migration <Name>`, `Update-Database`.
   - Tooling package: `Microsoft.EntityFrameworkCore.Tools` (added to project in Task 6).
   - Requires zero global tool installations.
2. **.NET CLI Tooling (`dotnet ef`):**
   - Commands: `dotnet ef migrations add <Name>`, `dotnet ef database update`.
   - Requires the global CLI tool (`dotnet tool install --global dotnet-ef`).
- **Policy:** In accordance with Task 2 restrictions, no NuGet packages or global tools will be installed until authorized in Task 6. Both workflows will be fully supported.

---

## 5. Security & Credentials Policy

- **Zero Plaintext Passwords:** SQL Server Express connects via **Windows Authentication** (`Integrated Security=True` / `Trusted_Connection=True`). This means your current Windows login automatically authenticates you with full administrative privileges without needing database usernames or passwords.
- **Chat Privacy:** Never share database passwords, Windows credentials, or connection secrets in chat messages or public Git repositories.
