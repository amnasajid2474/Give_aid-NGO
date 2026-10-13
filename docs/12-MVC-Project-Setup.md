# Give-AID — ASP.NET Core MVC Project Foundation Setup

**Document ID:** `DOC-12-MVC`  
**Task ID:** `TASK-04` — Create the ASP.NET Core MVC Project  
**Project Name:** Give-AID — NGO Management & Donation Website  
**Status:** Successfully Created, Built & Smoke-Tested  
**Date:** October 2026  

---

## 1. Project Specifications & Environment

| Parameter | Configuration Detail | Verification Status |
| :--- | :--- | :---: |
| **Workspace Root** | `D:\Give-AID NGO` | Verified |
| **Solution File(s)** | `D:\Give-AID NGO\GiveAid.sln` & `GiveAid.slnx` | **Active** |
| **Web Project Folder** | `D:\Give-AID NGO\GiveAid.Web` | **Active** |
| **Project File** | `GiveAid.Web\GiveAid.Web.csproj` | **Active** |
| **Target Framework** | .NET 10 (`net10.0`) | **Verified** |
| **SDK Version** | `10.0.401` | **Verified** |
| **Root Namespace** | `GiveAid.Web` | **Verified** |
| **Application Type** | ASP.NET Core MVC (Model-View-Controller) | **Verified** |

---

## 2. Commands Executed for Creation

The standard, non-destructive .NET CLI commands were executed:

```powershell
# 1. Create classic Visual Studio solution and modern solution files
dotnet new sln --format sln -n GiveAid
dotnet new sln --format slnx -n GiveAid

# 2. Create the clean ASP.NET Core MVC application template
dotnet new mvc -n GiveAid.Web -o GiveAid.Web

# 3. Add project to solutions
dotnet sln GiveAid.sln add GiveAid.Web/GiveAid.Web.csproj
dotnet sln GiveAid.slnx add GiveAid.Web/GiveAid.Web.csproj
```

---

## 3. Directory & File Structure Breakdown

The generated application maintains clean separation of concerns:

```
D:\Give-AID NGO\
├── GiveAid.sln                         <-- Visual Studio Solution file (classic)
├── GiveAid.slnx                        <-- Visual Studio Solution file (modern XML)
├── GiveAid.Web\                        <-- Main Web Application Project
│   ├── Controllers\                    <-- Presentation logic & HTTP action endpoints
│   │   └── HomeController.cs           <-- Default controller with Index, Privacy, Error actions
│   ├── Models\                         <-- Data structures & ViewModels
│   │   └── ErrorViewModel.cs           <-- Diagnostic model for request correlation IDs
│   ├── Views\                          <-- Razor HTML presentation templates (.cshtml)
│   │   ├── Home\
│   │   │   ├── Index.cshtml            <-- Landing page view
│   │   │   └── Privacy.cshtml          <-- Privacy policy page view
│   │   ├── Shared\
│   │   │   ├── _Layout.cshtml          <-- Global master layout (header, nav, body, footer)
│   │   │   └── Error.cshtml            <-- User-facing error template
│   │   ├── _ViewImports.cshtml         <-- Global Razor directives and tag helper imports
│   │   └── _ViewStart.cshtml           <-- Sets default master layout for all views
│   ├── wwwroot\                        <-- Web server static assets
│   │   ├── css\site.css                <-- Global application stylesheet
│   │   ├── js\site.js                  <-- Global JavaScript
│   │   └── lib\                        <-- Client libraries (Bootstrap 5, jQuery)
│   ├── Properties\
│   │   └── launchSettings.json         <-- Local development port and HTTPS configurations
│   ├── appsettings.json                <-- Application configuration (non-secret settings)
│   ├── appsettings.Development.json    <-- Local development logging settings
│   ├── Program.cs                      <-- Application entry point, DI container & middleware pipeline
│   └── GiveAid.Web.csproj              <-- Project compilation definition & framework target
├── docs\                               <-- Architectural & requirements documentation
└── tasks\                              <-- Project roadmap task specifications
```

---

## 4. Key Files Explained (Beginner's Guide)

1. **`Program.cs`:** The engine of an ASP.NET Core application. It configures dependency injection services (`builder.Services.AddControllersWithViews()`), sets up routing middleware (`app.MapControllerRoute(...)`), and starts the web host.
2. **`Controllers/HomeController.cs`:** Inherits from `Controller`. Contains action methods returning `IActionResult`. When a visitor requests `/` or `/Home/Index`, `Index()` returns `View()`.
3. **`Views/Shared/_Layout.cshtml`:** The master visual shell containing HTML `<head>`, navbar, and footer. Every page injects its unique content into `@RenderBody()`.
4. **`wwwroot/`:** Only files placed inside `wwwroot/` are directly accessible to web browsers (CSS files, JavaScript files, images, client libraries).
5. **`GiveAid.Web.csproj`:** Declares `<TargetFramework>net10.0</TargetFramework>`, nullable reference types, and implicit usings.

---

## 5. Build and Smoke Test Verification

### 5.1 Build Result
```text
dotnet build GiveAid.sln

Determining projects to restore...
All projects are up-to-date for restore.
GiveAid.Web -> D:\Give-AID NGO\GiveAid.Web\bin\Debug\net10.0\GiveAid.Web.dll

Build succeeded.
    0 Warning(s)
    0 Error(s)
Time Elapsed 00:00:12.52
```

### 5.2 Live HTTP Smoke Test
The development server was launched on `http://127.0.0.1:5000` and automated HTTP requests were dispatched:
- **`GET /` (Home/Index):** Returned **HTTP 200 OK** (Content-Length: 2,573 bytes).
- **`GET /Home/Privacy`:** Returned **HTTP 200 OK**.
- **Result:** Default routing, Razor view compilation, and static asset pipeline verified functional.

---

## 6. Acceptance Criteria Checklist (TASK-04)

- [x] Project created at approved path `D:\Give-AID NGO\GiveAid.Web`.
- [x] Compatible target framework (.NET 10) selected and documented.
- [x] Solution files (`GiveAid.sln` and `GiveAid.slnx`) properly link the project.
- [x] Solution builds with 0 errors and 0 warnings.
- [x] Default application runs and responds with HTTP 200 on local host.
- [x] Standard MVC structure verified (`Controllers`, `Models`, `Views`, `wwwroot`, `Program.cs`).
- [x] No unauthorized packages, migrations, or database tables created.
- [x] Git status clean and ready for user commit approval.
