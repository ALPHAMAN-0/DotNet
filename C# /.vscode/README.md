# How to Run C# Files in VS Code

## 🎯 Using the Run and Debug Button (F5)

1. **Open your C# file** (like test.cs) in VS Code
2. **Click the Run and Debug button** in the left sidebar (looks like a play button with a bug)
3. **Click the green play button** at the top that says "Run C# File"
4. **OR press F5** on your keyboard

Your code will:
- ✅ Automatically compile
- ✅ Run in the VS Code terminal
- ✅ Show any errors if compilation fails
- ✅ Clean up temporary files automatically

## 🚀 Alternative Methods

### Method 1: Build Task (Cmd+Shift+B)
- Press `Cmd+Shift+B` to run the build task
- This will use the script to compile and run your file

### Method 2: Terminal Script
```bash
./run-cs.sh test.cs
```

## 📝 Creating New C# Files

Just create a new file with `.cs` extension:

```csharp
using System;

class MyProgram
{
    static void Main()
    {
        Console.WriteLine("Hello World!");
        // Your code here
    }
}
```

## 🐛 Debugging

The same F5 button also works for debugging:
- Set breakpoints by clicking in the left margin
- Press F5 to start debugging
- Use the debug controls to step through your code

## ⚙️ VS Code Configuration Files

### `.vscode/launch.json` - Debug Configuration
```json
{
    "version": "0.2.0",
    "configurations": [
        {
            "name": "Run C# File",
            "type": "coreclr",
            "request": "launch",
            "preLaunchTask": "build-current-file",
            "program": "${workspaceFolder}/temp_run/TempRun/bin/Debug/net9.0/TempRun.dll",
            "args": [],
            "cwd": "${workspaceFolder}/temp_run/TempRun",
            "console": "integratedTerminal",
            "stopAtEntry": false
        }
    ]
}
```

### `.vscode/tasks.json` - Build Tasks
```json
{
    "version": "2.0.0",
    "tasks": [
        {
            "label": "Run C# File",
            "type": "shell",
            "command": "./run-cs.sh",
            "args": ["${file}"],
            "group": {
                "kind": "build",
                "isDefault": true
            },
            "presentation": {
                "echo": true,
                "reveal": "always",
                "focus": false,
                "panel": "shared",
                "showReuseMessage": true,
                "clear": true
            },
            "problemMatcher": "$msCompile"
        },
        {
            "label": "build-current-file",
            "type": "shell",
            "command": "mkdir -p temp_run && cd temp_run && dotnet new console -n TempRun --force --no-restore && cp '${file}' TempRun/Program.cs && cd TempRun && dotnet restore && dotnet build",
            "group": "build",
            "presentation": {
                "echo": false,
                "reveal": "silent",
                "focus": false,
                "panel": "shared"
            },
            "problemMatcher": "$msCompile"
        },
        {
            "label": "cleanup-temp",
            "type": "shell",
            "command": "rm -rf temp_run",
            "group": "build",
            "presentation": {
                "echo": false,
                "reveal": "never"
            }
        }
    ]
}
```

---

**Ready to go!** Your C# environment is fully configured! 🎉
