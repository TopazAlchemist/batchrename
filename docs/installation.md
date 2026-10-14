# Installation Guide — Windows 10/11

## Requirements

| | |
|---|---|
| OS | Windows 10 build 18363+ or Windows 11 |
| Architecture | x64 |
| Disk space | ~50 MB |
| Admin rights | UAC prompt on first run (system features only) |

## Method 1: Installer (recommended)

### Step 1 — Download

Go to [Releases](https://github.com/yourname/batchrename/releases/latest) and
download `batchrename-Setup-1.2.0.exe`.

> ✅ Verify the download with the published SHA-256:
> ```powershell
> Get-FileHash .\batchrename-Setup-1.2.0.exe -Algorithm SHA256
> ```

### Step 2 — Run installer

SmartScreen may warn for new releases (no paid EV certificate — we're free &
open source). Click **More info → Run anyway**.
*(Screenshot: `assets/screenshots/install-1.png`)*

### Step 3 — Choose options

- ✅ Desktop shortcut
- ✅ Launch on startup (optional)
- ❌ NOT required: disable antivirus, change BIOS

### Step 4 — First run

One-time UAC prompt if the tool manages system settings. No drivers, no
services installed.

## Method 2: winget

```powershell
winget install batchrename
```

## Method 3: Portable

Download `batchrename-Portable-1.2.0.zip`, extract anywhere (USB works), run
`batchrename.exe --portable`.

## Uninstall

Settings → Apps → batchrename → Uninstall. Portable: delete the folder.
