$ErrorActionPreference = 'Stop'
Set-Location $PSScriptRoot
$locator = Join-Path ${env:ProgramFiles(x86)} 'Microsoft Visual Studio/Installer/vswhere.exe'
if (-not (Test-Path $locator)) { throw 'Visual Studio / Build Tools with WPF support is required.' }
$vs = & $locator -latest -property installationPath
$msbuild = Join-Path $vs 'MSBuild/Current/Bin/MSBuild.exe'
if (-not (Get-Command nuget -ErrorAction SilentlyContinue)) { throw 'NuGet CLI must be on PATH.' }
nuget restore packages.config -PackagesDirectory ../packages -NonInteractive
if ($LASTEXITCODE -ne 0) { throw 'Dependency restore failed.' }
nuget install Microsoft.NETFramework.ReferenceAssemblies.net452 -Version 1.0.3 -OutputDirectory ../packages -NonInteractive
if ($LASTEXITCODE -ne 0) { throw 'Reference assembly restore failed.' }
$referenceRoot = (Resolve-Path '../packages/Microsoft.NETFramework.ReferenceAssemblies.net452.1.0.3/build').Path
& $msbuild UnderTheSea.csproj /p:Configuration=Debug "/p:TargetFrameworkRootPath=$referenceRoot" /verbosity:minimal /nologo
if ($LASTEXITCODE -ne 0) { throw 'Build failed.' }
Write-Host 'Desktop application compiled. Database setup is separate; see README.md.'
