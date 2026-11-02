$ErrorActionPreference = 'Stop'
$root = Split-Path $PSScriptRoot -Parent
$output = Join-Path $root 'dist/FreeSMS-Original-Net10'
Push-Location (Join-Path $root 'dotnet')
try {
    dotnet publish FreeSms.Original.Windows/FreeSms.Original.Windows.csproj -c Release -r win-x86 --self-contained true -o $output
    if ($LASTEXITCODE -ne 0) { throw 'Application build failed.' }
    $reportHost = Join-Path $output 'report-host'
    dotnet build FreeSms.ReportHost/FreeSms.ReportHost.csproj -c Release -o $reportHost
    if ($LASTEXITCODE -ne 0) { throw 'Report host build failed.' }
    $process = Start-Process (Join-Path $reportHost 'FreeSms.ReportHost.exe') -ArgumentList '--export-license-context' -Wait -PassThru
    if ($process.ExitCode -ne 0) { throw 'The original component license resource could not be converted.' }
    Copy-Item (Join-Path $root 'vendor/runtime/CRRedist2005_x86.msi') $output
    Copy-Item (Join-Path $root 'README.md') (Join-Path $output 'README-FA.md')
    Copy-Item (Join-Path $root 'scripts/Setup-Reports.cmd') $output
    Write-Host "Built: $output/school_Af.exe"
} finally { Pop-Location }
