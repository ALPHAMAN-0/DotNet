- No root-level build/test/lint manifest (no package.json/go.mod/pyproject.toml/Cargo.toml) — this is a multi-project .NET repo; each top-level folder is its own independent `.csproj`/`.sln`
- Build/test/lint commands: TODO: verify — none observed directly in this repo (no CI config, no scripts file read)
- Rule: there is no single app to build — pick the specific project folder first (e.g. `MongoDB API/`, `MVC/Buisness/`) before running any `dotnet` command
- Files worth reading first:
  - `README.md` — repo overview and per-folder contents table
  - `ARCHITECTURE.md` — component map of the repo
  - `MongoDB API/Program.cs` — representative ASP.NET Core Web API entry point

Architecture: see ARCHITECTURE.md — read before structural changes
