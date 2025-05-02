# ASP.NET Core Starter Guide

This repository provides a beginner-friendly guide to **ASP.NET Core**, including what it is, how it differs from **.NET Framework**, and how to set up a development environment.

## Table of Contents
- [What is ASP.NET Core?](#what-is-aspnet-core)
- [Differences Between .NET Framework and .NET Core](#differences-between-net-framework-and-net-core)
- [Setting Up the Development Environment](#setting-up-the-development-environment)
- [Key Concepts for Beginners](#key-concepts-for-beginners)
- [How to Run the Sample Project](#how-to-run-the-sample-project)
- [Resources](#resources)

## What is ASP.NET Core?

**ASP.NET Core** is a modern, open-source framework by Microsoft for building web applications and APIs. It’s fast, cross-platform (Windows, macOS, Linux), and perfect for creating websites, APIs, or cloud-based apps.

### Key Features
- **Cross-Platform**: Runs on any operating system.
- **Fast**: Optimized for high performance.
- **Open-Source**: Code is available on GitHub.
- **Flexible**: Build websites, APIs, or real-time apps.

## Differences Between .NET Framework and .NET Core

| Feature | .NET Framework | .NET Core (now .NET) |
|---------|----------------|----------------------|
| **Platform** | Windows-only | Windows, macOS, Linux |
| **Performance** | Slower | Faster |
| **Open-Source** | Mostly proprietary | Fully open-source |
| **Use Case** | Legacy desktop/web apps | Modern web/cloud apps |
| **Updates** | Rarely updated | Yearly updates |

**Recommendation**: Use .NET Core (or .NET) for new projects.

## Setting Up the Development Environment

Follow these steps to set up your computer for ASP.NET Core development.

### 1. Install .NET SDK
- Download the latest **.NET SDK** from [dotnet.microsoft.com](https://dotnet.microsoft.com/download).
- Install it and verify with:
  ```bash
  dotnet --version