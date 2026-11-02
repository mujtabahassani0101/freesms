$ErrorActionPreference = 'Stop'
$root = Split-Path $PSScriptRoot -Parent
$output = Join-Path $root 'dist/FreeSMS-Original-Net10'
Push-Location (Join-Path $root 'dotnet')
try {
    dotnet publish FreeSms.Original.Windows/FreeSms.Original.Windows.csproj -c Release -r win-x86 --self-contained true -o $output
    if ($LASTEXITCODE -ne 0) { throw 'Application build failed.' }
    Copy-Item (Join-Path $root 'README.md') (Join-Path $output 'README-FA.md')
    Write-Host "Built: $output/school_Af.exe"
} finally { Pop-Location }
