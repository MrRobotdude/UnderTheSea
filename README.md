# UnderTheSea

A C# desktop training project by Doddie Prawarjito, exploring operations across attractions, hospitality, purchasing, finance, and human resources.

**Context:** training project using WPF, Caliburn.Micro, Dapper, and SQL Server. This is useful as a supporting portfolio example of desktop application structure; it should not be described as a deployed business system.

## What the source includes

- Department-specific views and view models.
- Employee login and department navigation.
- Attraction and maintenance screens.
- Hotel and dining workflows.
- Purchasing, funding requests, and management screens.

## Setup and current limitation

The original project targets .NET Framework 4.5.2 and uses packages.config. Restore NuGet packages to the parent packages directory (the existing HintPaths expect ../packages), then build with Visual Studio/MSBuild and the matching .NET Framework targeting pack.

```powershell
nuget restore packages.config -PackagesDirectory ../packages
msbuild UnderTheSea.csproj /p:Configuration=Debug
```

App.config uses local SQL Server Express and a database named UnderTheSea. **The original database schema and stored procedure scripts are absent from this repository.** The full application cannot be reproduced from source alone until those assets are recovered or reconstructed. Do not substitute a fabricated database and claim it is the original complete system.

The login preparation parameterizes employee lookup, handles unknown users and unavailable databases, rejects retired accounts, and masks password input. The legacy database still compares stored passwords directly; password hashing and a full query review are prerequisites for real-world use.

## Portfolio

[Case study](docs/CASE_STUDY.md) · [Demo walkthrough](docs/DEMO.md). Present its architecture and training context while clearly identifying the missing runtime assets.

## Reconstructed ticketing demo

The original database is unavailable. A separate synthetic schema now supports attraction login, ticket sale, lookup, cancellation, and admission. It does not restore hotel, finance, HR, or other department workflows. Unsupported employee actions are disabled in demo mode.

Install SQL Server LocalDB, sqlcmd, Visual Studio WPF build tools, and NuGet CLI. From this repository:

```powershell
.\Build-Portfolio.ps1
sqllocaldb start MSSQLLocalDB
sqlcmd -S '(localdb)\MSSQLLocalDB' -E -b -Q "CREATE DATABASE UnderTheSeaPortfolioDemo"
sqlcmd -S '(localdb)\MSSQLLocalDB' -E -b -d UnderTheSeaPortfolioDemo -i database/portfolio-demo.sql
.\Start-Demo.ps1
```

Use **demo-attraction / demo-only**. Run the creation commands once against a new database; the schema script refuses to overwrite existing demo tables. Keep this local synthetic demo isolated. Generated bin/obj files are excluded from version control.
