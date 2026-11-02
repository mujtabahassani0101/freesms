$ErrorActionPreference = 'Stop'
$root = Split-Path $PSScriptRoot -Parent
$output = Join-Path $root 'dist/FreeSMS-Native-Compatible'
Push-Location (Join-Path $root 'dotnet')
try {
    dotnet publish FreeSms.NativeLauncher/FreeSms.NativeLauncher.csproj -c Release -r win-x64 --self-contained true -o $output
    if ($LASTEXITCODE -ne 0) { throw 'Native .NET 10 bootstrap build failed.' }
    dotnet build FreeSms.Original.Framework/FreeSms.Original.Framework.csproj -c Release -o (Join-Path $output 'legacy-ui')
    if ($LASTEXITCODE -ne 0) { throw 'Original application compatibility build failed.' }
    Copy-Item (Join-Path $root 'vendor/runtime/CRRedist2005_x86.msi') $output
    Copy-Item (Join-Path $root 'scripts/Setup-Reports.cmd') $output
    Copy-Item (Join-Path $root 'README.md') (Join-Path $output 'README-FA.md')
    Write-Host "Built: $output/FreeSMS.exe"
} finally { Pop-Location }
