$ErrorActionPreference = 'Stop'
Set-Location $PSScriptRoot
$app = Join-Path $PSScriptRoot 'bin/Debug/UnderTheSea.exe'
if (-not (Test-Path $app)) { throw 'Build the Debug application first. See README.md.' }
$databaseCount = & sqlcmd -S '(localdb)\MSSQLLocalDB' -E -Q "SET NOCOUNT ON; SELECT COUNT(*) FROM sys.databases WHERE name='UnderTheSeaPortfolioDemo';" -h -1 -W -b
if ($LASTEXITCODE -ne 0) { throw 'SQL LocalDB is unavailable.' }
if (($databaseCount | Out-String).Trim() -ne '1') { throw 'Create the dedicated demo database and run database/portfolio-demo.sql first.' }
$previousDemoMode = $env:UNDER_THE_SEA_DEMO
try {
    $env:UNDER_THE_SEA_DEMO = '1'
    Write-Host 'Reconstructed ticketing demo: demo-attraction / demo-only. Other department workflows are outside this demo.'
    Start-Process -FilePath $app -WindowStyle Hidden
} finally { $env:UNDER_THE_SEA_DEMO = $previousDemoMode }
