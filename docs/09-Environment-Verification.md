# Give-AID — Development Environment Verification Report

**Document ID:** `DOC-09-VER`  
**Task ID:** `TASK-02` — Tools and Development Environment Setup  
**Project Name:** Give-AID — NGO Management & Donation Website  
**Evaluation Status:** 100% Verified & Passed  
**Date:** October 2026  

---

## 1. Executive Summary

This report documents the live verification results of the developer environment on the host Windows machine. All mandatory tools required for building, debugging, and persisting the Give-AID ASP.NET Core MVC web application were inspected using safe, read-only diagnostic commands.

---

## 2. Tool Verification Audit Log

| Tool / Component | Verification Command Executed | Expected Outcome | Actual Verified Result | Status |
| :--- | :--- | :--- | :--- | :---: |
| **.NET SDK** | `dotnet --list-sdks` | Supported .NET SDK listed in PATH | `10.0.401 [C:\Program Files\dotnet\sdk]` | **READY** |
| **ASP.NET Core Runtime** | `dotnet --info` | `Microsoft.AspNetCore.App` runtime present | `Microsoft.AspNetCore.App 10.0.12` present | **READY** |
| **Visual Studio IDE** | `vswhere.exe` | Visual Studio installed and launchable | `Visual Studio Community 2026` (v18.10.1) at `C:\Program Files\Microsoft Visual Studio\18\Community` | **READY** |
| **ASP.NET Workload** | `vswhere.exe -requires Microsoft.VisualStudio.Workload.NetWeb` | `NetWeb` workload present | Verified installed in instance `b2727458` | **READY** |
| **SQL Server Engine** | `Get-Service *SQL*` | Database service running | Service `MSSQL$SQLEXPRESS` is **Running** | **READY** |
| **SQL Server Connectivity** | `SqlConnection("Server=.\SQLEXPRESS;...")` | Successful database handshake | Connected successfully! Engine Version: `17.00.1000` | **READY** |
| **SSMS GUI Client** | `vswhere.exe` for SSMS | SSMS client installed | `SQL Server Management Studio 22` (v22.5.2) installed | **READY** |
| **Git Version Control** | `git --version` | Git 2.x present in PATH | `git version 2.54.0.windows.1` at `C:\Program Files\Git\cmd\git.exe` | **READY** |
| **PowerShell Environment** | `$PSVersionTable.PSVersion` | Windows PowerShell available | PowerShell `5.1.19041.6456` active | **READY** |

---

## 3. Raw Diagnostic Outputs

### 3.1 .NET SDK & Runtime
```text
.NET SDK:
 Version:           10.0.401
 Commit:            e34a38d2ae
 MSBuild version:   18.9.11+e34a38d2a

.NET runtimes installed:
  Microsoft.AspNetCore.App 10.0.12 [C:\Program Files\dotnet\shared\Microsoft.AspNetCore.App]
  Microsoft.NETCore.App 10.0.12 [C:\Program Files\dotnet\shared\Microsoft.NETCore.App]
  Microsoft.WindowsDesktop.App 10.0.12 [C:\Program Files\dotnet\shared\Microsoft.WindowsDesktop.App]
```

### 3.2 Visual Studio Community 2026
```text
displayName: Visual Studio Community 2026
installationVersion: 18.10.12210.168
installationPath: C:\Program Files\Microsoft Visual Studio\18\Community
productPath: C:\Program Files\Microsoft Visual Studio\18\Community\Common7\IDE\devenv.exe
Workload: Microsoft.VisualStudio.Workload.NetWeb (Installed)
```

### 3.3 SQL Server Database Engine
```text
Status   Name               DisplayName
------   ----               -----------
Running  MSSQL$SQLEXPRESS   SQL Server (SQLEXPRESS)

Connection Test Handshake:
SQL Express Connected! ServerVersion: 17.00.1000
Authentication: Windows Integrated Security (No password required)
Instance Name: .\SQLEXPRESS
```

### 3.4 SQL Server Management Studio (SSMS)
```text
displayName: SQL Server Management Studio 22
installationVersion: 22.5.11723.231
installationPath: C:\Program Files\Microsoft SQL Server Management Studio 22\Release
```

### 3.5 Git Version Control
```text
git version 2.54.0.windows.1
Path: C:\Program Files\Git\cmd\git.exe
```

---

## 4. Remaining Setup Actions & Readiness Checklist

- [x] Visual Studio with ASP.NET and web development workload verified.
- [x] .NET SDK and ASP.NET Core runtime verified.
- [x] Microsoft SQL Server Database Engine verified and running.
- [x] SQL Server Management Studio (SSMS) verified.
- [x] Git version control verified.
- [x] Development connection string confirmed: `Server=.\SQLEXPRESS;Database=GiveAidDb;Integrated Security=True;TrustServerCertificate=True;MultipleActiveResultSets=true`.
- [ ] Task 3: Initialize Git repository, `.gitignore`, and backup strategy (Pending Task 2 approval).
- [ ] Task 4: Create ASP.NET Core MVC Project (Pending Task 3).

---

## 5. Verification Sign-Off

All required developer tools are fully installed, operational, and compatible. **No software downloads, installation wizards, or system reboots are required.** Task 2 is complete.
