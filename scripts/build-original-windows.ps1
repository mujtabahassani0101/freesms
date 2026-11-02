$ErrorActionPreference = 'Stop'
$root = Split-Path $PSScriptRoot -Parent
$output = Join-Path $root 'dist/FreeSMS-Net10'
$staging = Join-Path $root ('dist/.FreeSMS-build-' + [Guid]::NewGuid().ToString('N'))
Push-Location (Join-Path $root 'dotnet')
try {
    dotnet publish FreeSms.Original.Windows/FreeSms.Original.Windows.csproj -c Release -r win-x86 --self-contained true -p:PublishReadyToRun=true -o $staging
    if ($LASTEXITCODE -ne 0) { throw 'Application build failed.' }
    Copy-Item (Join-Path $root 'README.md') (Join-Path $staging 'README-FA.md')
    $notices = Join-Path $staging 'licenses'
    New-Item -ItemType Directory -Force $notices | Out-Null
    $packages = @{}
    $folders = @{}
    foreach ($name in @('FreeSms.Original.Windows', 'FreeSms.Core', 'FreeSms.NativeControls', 'FreeSms.Reports')) {
        $assets = Get-Content -Raw (Join-Path $root "dotnet/$name/obj/project.assets.json") | ConvertFrom-Json
        foreach ($folder in $assets.packageFolders.PSObject.Properties.Name) { $folders[$folder] = $true }
        foreach ($library in $assets.libraries.PSObject.Properties) {
            if ($library.Value.type -eq 'package') { $packages[$library.Value.path] = $true }
        }
    }
    foreach ($name in @('microsoft.netcore.app.runtime.win-x86', 'microsoft.windowsdesktop.app.runtime.win-x86', 'microsoft.aspnetcore.app.runtime.win-x86')) { $packages["$name/10.0.14"] = $true }
    foreach ($package in $packages.Keys) {
        foreach ($folder in $folders.Keys) {
            $path = Join-Path $folder $package
            if (Test-Path $path) {
                Get-ChildItem $path -File | Where-Object { $_.Name -match '^(LICENSE|THIRD-PARTY|NOTICE)' } | ForEach-Object {
                    Copy-Item $_.FullName (Join-Path $notices ($package.Replace('/', '-') + '-' + $_.Name)) -Force
                }
                break
            }
        }
    }
    $packages.Keys | Sort-Object | ConvertTo-Json | Set-Content -Encoding UTF8 (Join-Path $notices 'packages.json')
    $backup = $null
    if (Test-Path $output) {
        $backup = Join-Path $root ('dist/previous/FreeSMS-' + [Guid]::NewGuid().ToString('N'))
        New-Item -ItemType Directory -Force (Split-Path $backup -Parent) | Out-Null
        Move-Item $output $backup
    }
    try { Move-Item $staging $output }
    catch {
        if ($backup -and !(Test-Path $output)) { Move-Item $backup $output }
        throw
    }
    Write-Host "Built: $output/FreeSMS.exe"
} finally {
    Pop-Location
    if (Test-Path $staging) { Remove-Item -Recurse -Force $staging }
}
