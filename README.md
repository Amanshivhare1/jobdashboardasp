# JobDashboard (.NET 6 Web API)

## Overview
A production-ready backend for your job dashboard, using ASP.NET Core Web API, MySQL, and JWT authentication. Static files (frontend) are served from the `wwwroot` folder.

---

## Setup

1. **Install .NET 6 SDK**
2. **Install MySQL** and create a database (see `appsettings.json` for connection string)
3. **Configure `appsettings.json`** with your MySQL credentials and JWT secret
4. **Place your frontend files** (HTML, CSS, JS, assets) in the `wwwroot/` folder

---

## Build & Run (Development)

```
dotnet restore
dotnet build
dotnet run
```

---

## Publish & Deploy to IIS

1. **Publish the project:**
   ```
   dotnet publish -c Release -o ./publish
   ```
2. **Copy the `publish/` folder** to your IIS server
3. **In IIS Manager:**
   - Add a new site or app pointing to the `publish/` folder
   - Set the .NET CLR version to "No Managed Code" (for ASP.NET Core)
   - Ensure the Application Pool is running
   - Set environment variables for production secrets (optional)
4. **Browse to your site**

---

## Notes
- All API endpoints are under `/api/`
- Static files are served from `/`
- Update CORS policy in `Startup.cs` as needed
- For HTTPS, configure IIS bindings

---

## Troubleshooting
- Check IIS logs and Windows Event Viewer for errors
- Ensure the correct .NET Hosting Bundle is installed on the server
- Make sure MySQL is accessible from the server

---

## Structure
- `Controllers/` - API endpoints
- `Models/` - Data models
- `Services/` - Business logic
- `wwwroot/` - Frontend static files
