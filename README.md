# DotNet

A comprehensive .NET learning repository covering the .NET Framework, ASP.NET Core, C#, MVC architecture, Web APIs, MongoDB integration, and Windows Forms.

## Contents

| Folder | Description | Key Concepts |
|--------|-------------|-------------|
| `C#/` | C# programming fundamentals | Syntax, OOP, LINQ, collections |
| `HelloWorldNew/` | Starter .NET project | Project setup, dotnet CLI |
| `MVC/` | ASP.NET MVC pattern | Controllers, views, models, routing |
| `MVC 01/` | Additional MVC examples | Middleware, dependency injection |
| `Web API/` | RESTful API development | HTTP methods, JSON serialization, endpoints |
| `MongoDB API/` | API with MongoDB backend | NoSQL, MongoDB driver, CRUD operations |
| `Windows Froms(AIUB)/` | Desktop applications | WinForms UI, event-driven programming |
| `Project 1/` | Practice project | Full-stack .NET application |
| `RIder/` | JetBrains Rider examples | IDE-specific workflows |

## .NET Framework Overview

### What is .NET?

.NET is a free, cross-platform, open-source developer platform created by Microsoft for building many different types of applications. With .NET, you can use multiple languages (C#, F#, or Visual Basic), libraries, and editors to build web, mobile, desktop, games, IoT, and more.

### How .NET Works

1. **Common Language Runtime (CLR)**: The execution engine that handles memory management, type safety, exception handling, garbage collection, and thread management.
2. **Framework Class Library (FCL)**: A comprehensive collection of reusable types for data access, file I/O, networking, and more.
3. **Compilation Process**: Applications are compiled to Intermediate Language (IL) code, then JIT-compiled to native machine code at runtime.
4. **Language Interoperability**: Different .NET languages can work together and share the same libraries.

### Key Components

| Component | Purpose |
|-----------|---------|
| **.NET Core/.NET 5+** | Modern, cross-platform implementation |
| **ASP.NET Core** | Web framework for cloud-based applications |
| **Entity Framework Core** | Object-database mapper for data access |
| **Xamarin/MAUI** | Mobile application development |
| **ML.NET** | Machine learning integration |
| **Blazor** | Interactive web UIs using C# |

### .NET Framework vs .NET Core

| Feature | .NET Framework | .NET Core (now .NET) |
|---------|----------------|----------------------|
| **Platform** | Windows-only | Windows, macOS, Linux |
| **Performance** | Slower | Faster |
| **Open-Source** | Mostly proprietary | Fully open-source |
| **Use Case** | Legacy desktop/web apps | Modern web/cloud apps |
| **Updates** | Rarely updated | Yearly updates |

> **Recommendation**: Use .NET Core (or .NET 8+) for all new projects.

## ASP.NET Core

**ASP.NET Core** is a modern, open-source framework by Microsoft for building web applications and APIs. It's fast, cross-platform, and perfect for creating websites, APIs, or cloud-based apps.

### Key Features
- **Cross-Platform**: Runs on Windows, macOS, and Linux
- **High Performance**: Optimized for speed
- **Open-Source**: Community-driven development
- **Flexible**: Build websites, APIs, or real-time apps

## Getting Started

### Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download) (latest version)
- Visual Studio 2022, VS Code, or JetBrains Rider

### Quick Start
```bash
# Verify installation
dotnet --version

# Create a new project
dotnet new webapi -n MyFirstApi

# Run the project
cd MyFirstApi
dotnet run
```

## Resources
- [Official .NET Documentation](https://learn.microsoft.com/en-us/dotnet/)
- [ASP.NET Core Documentation](https://learn.microsoft.com/en-us/aspnet/core/)
- [C# Programming Guide](https://learn.microsoft.com/en-us/dotnet/csharp/)
