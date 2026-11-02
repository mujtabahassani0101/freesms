using System.Diagnostics;
using System.Text.RegularExpressions;
using Microsoft.Data.SqlClient;

namespace FreeSms.Core;

public sealed record DatabaseOptions(string DataDirectory, string Instance = "FreeSMS", string Name = "free_sms")
{
    public static DatabaseOptions Default => new(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "free-sms", "windows-db"));
}

/// <summary>Starts the user's native Windows LocalDB instance, without a container or a VM.</summary>
public static partial class Bootstrapper
{
    public static async Task<Database> OpenAsync(string root, DatabaseOptions? options = null, IProgress<string>? progress = null, CancellationToken cancellation = default)
    {
        var configured = Environment.GetEnvironmentVariable("FREE_SMS_CONNECTION_STRING");
        if (options is null && !string.IsNullOrWhiteSpace(configured))
        {
            var external = new SqlConnectionStringBuilder(configured);
            if (string.IsNullOrWhiteSpace(external.InitialCatalog)) throw new InvalidOperationException("نام بانک را در رشتهٔ اتصال مشخص کنید.");
            return new Database(external.ConnectionString);
        }
        if (!OperatingSystem.IsWindows()) throw new PlatformNotSupportedException("اجرای بانک محلی این نسخه به SQL Server Express LocalDB بومی ویندوز نیاز دارد.");
        options ??= DatabaseOptions.Default;
        Validate(options);
        var utility = FindLocalDbUtility() ?? throw new FileNotFoundException("SQL Server Express LocalDB روی ویندوز نصب نیست. بستهٔ بومی LocalDB را نصب کنید؛ راهنما در README است.");
        Directory.CreateDirectory(options.DataDirectory);
        using var bootstrapLock = await AcquireLockAsync(Path.Combine(options.DataDirectory, "bootstrap.lock"), cancellation);
        progress?.Report("راه‌اندازی بانک بومی ویندوز...");
        // Some SqlLocalDB utility versions return exit code zero even for a missing instance.
        // 'create' is safe for an existing named instance; verify the actual running pipe below.
        var created = await RunLocalDbAsync(utility, cancellation, "create", options.Instance);
        var started = await RunLocalDbAsync(utility, cancellation, "start", options.Instance);
        if (started.Code != 0) throw new InvalidOperationException("بانک محلی شروع نشد: " + started.Error);
        var running = await RunLocalDbAsync(utility, cancellation, "info", options.Instance);
        if (running.Code != 0) throw new InvalidOperationException("مشخصات نمونهٔ بانک خوانده نشد: " + running.Error);
        // Connect to the native pipe directly, avoiding LocalDB client API version/bitness conflicts.
        var connection = new SqlConnectionStringBuilder(LocalConnectionString(options)) { DataSource = PipeFromInstanceInfo(running.Output) };
        var database = new Database(connection.ConnectionString);
        await Task.Run(() =>
        {
            cancellation.ThrowIfCancellationRequested();
            using var server = database.Open("master");
            if (database.Scalar("SELECT DB_ID(@p0)", [options.Name], server) is not null) return;
            var (data, log) = PrepareSeedFiles(root, options);
            var identifier = Database.Identifier(options.Name);
            var dataLiteral = "N'" + data.Replace("'", "''") + "'";
            var logLiteral = "N'" + log.Replace("'", "''") + "'";
            database.Execute($"CREATE DATABASE {identifier} ON (FILENAME={dataLiteral}),(FILENAME={logLiteral}) FOR ATTACH", connection: server);
        }, cancellation);
        return database;
    }

    public static string LocalConnectionString(DatabaseOptions options)
    {
        Validate(options);
        return new SqlConnectionStringBuilder
        {
            DataSource = @"(localdb)\" + options.Instance, InitialCatalog = options.Name,
            IntegratedSecurity = true, ConnectTimeout = 30, Pooling = true,
            TrustServerCertificate = true, Encrypt = SqlConnectionEncryptOption.Optional,
            ApplicationName = "FreeSMS.NET10.Windows"
        }.ConnectionString;
    }

    /// <summary>Copies the distribution seed atomically, never overwriting an existing user database.</summary>
    public static (string Data, string Log) PrepareSeedFiles(string root, DatabaseOptions options)
    {
        Validate(options);
        var parent = Path.GetFullPath(options.DataDirectory);
        var live = Path.Combine(parent, options.Name);
        var data = Path.Combine(live, options.Name + ".mdf");
        var log = Path.Combine(live, options.Name + ".ldf");
        if (Directory.Exists(live))
        {
            if (!File.Exists(data) || !File.Exists(log)) throw new IOException("فایل‌های بانک محلی ناقص‌اند؛ برای حفاظت از داده‌ها جایگزین نشدند.");
            return (data, log);
        }
        Directory.CreateDirectory(parent);
        var staging = Path.Combine(parent, "seed-" + Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(staging);
        try
        {
            File.Copy(Path.Combine(root, "original/installed/db/school_af_kbr_Data.MDF"), Path.Combine(staging, options.Name + ".mdf"));
            File.Copy(Path.Combine(root, "original/installed/db/school_af_kbr_Log.LDF"), Path.Combine(staging, options.Name + ".ldf"));
            foreach (var path in Directory.GetFiles(staging)) File.SetAttributes(path, FileAttributes.Normal);
            Directory.Move(staging, live);
        }
        finally { if (Directory.Exists(staging)) Directory.Delete(staging, true); }
        return (data, log);
    }

    public static string? FindLocalDbUtility()
    {
        var programDirectories = new[] { Environment.GetEnvironmentVariable("ProgramW6432"), Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) }
            .Where(path => !string.IsNullOrWhiteSpace(path)).Distinct(StringComparer.OrdinalIgnoreCase);
        foreach (var programDirectory in programDirectories)
        {
            var directory = Path.Combine(programDirectory!, "Microsoft SQL Server");
            if (!Directory.Exists(directory)) continue;
            foreach (var version in Directory.GetDirectories(directory).OrderByDescending(path => int.TryParse(Path.GetFileName(path), out var number) ? number : 0))
            {
                if (!int.TryParse(Path.GetFileName(version), out var major) || major < 150) continue;
                var candidate = Path.Combine(version, "Tools", "Binn", "SqlLocalDB.exe");
                if (File.Exists(candidate)) return candidate;
            }
        }
        foreach (var path in (Environment.GetEnvironmentVariable("PATH") ?? "").Split(Path.PathSeparator))
        {
            if (string.IsNullOrWhiteSpace(path)) continue;
            var candidate = Path.Combine(path.Trim('"'), "SqlLocalDB.exe");
            if (File.Exists(candidate)) return candidate;
        }
        return null;
    }

    public static string PipeFromInstanceInfo(string output)
    {
        // SqlLocalDB may emit UTF-16 text to a redirected stream; the pipe itself is ASCII.
        var match = LocalPipe().Match(output.Replace("\0", ""));
        if (!match.Success) throw new InvalidOperationException("آدرس ارتباط نمونهٔ LocalDB پیدا نشد: " + output[..Math.Min(output.Length, 2000)]);
        var value = match.Value.Trim();
        return value.StartsWith("np:", StringComparison.OrdinalIgnoreCase) ? value : "np:" + value;
    }

    public static async Task<(int Code, string Output, string Error)> RunLocalDbAsync(string utility, CancellationToken cancellation, params string[] arguments)
    {
        var start = new ProcessStartInfo(utility) { RedirectStandardOutput = true, RedirectStandardError = true, UseShellExecute = false, CreateNoWindow = true };
        foreach (var argument in arguments) start.ArgumentList.Add(argument);
        using var process = Process.Start(start) ?? throw new InvalidOperationException("ابزار LocalDB اجرا نشد.");
        var output = process.StandardOutput.ReadToEndAsync(cancellation);
        var error = process.StandardError.ReadToEndAsync(cancellation);
        using var timeout = CancellationTokenSource.CreateLinkedTokenSource(cancellation);
        timeout.CancelAfter(TimeSpan.FromSeconds(60));
        try { await process.WaitForExitAsync(timeout.Token); }
        catch { if (!process.HasExited) process.Kill(true); throw; }
        return (process.ExitCode, await output, await error);
    }

    private static async Task<FileStream> AcquireLockAsync(string path, CancellationToken cancellation)
    {
        for (var attempt = 0; ; attempt++)
        {
            cancellation.ThrowIfCancellationRequested();
            try { return new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None); }
            catch (IOException) when (attempt < 299) { await Task.Delay(200, cancellation); }
        }
    }
    private static void Validate(DatabaseOptions options)
    {
        if (!SimpleName().IsMatch(options.Name) || !SimpleName().IsMatch(options.Instance) || new[] { "master", "model", "msdb", "tempdb" }.Contains(options.Name, StringComparer.OrdinalIgnoreCase))
            throw new ArgumentException("نام بانک یا نمونهٔ LocalDB معتبر نیست.");
        if (string.IsNullOrWhiteSpace(options.DataDirectory)) throw new ArgumentException("مسیر بانک مشخص نشده است.");
    }
    [GeneratedRegex(@"^[A-Za-z_][A-Za-z0-9_]{0,79}$")] private static partial Regex SimpleName();
    [GeneratedRegex(@"(?:np:)?\\\\\.\\pipe\\[^\r\n]+", RegexOptions.IgnoreCase)] private static partial Regex LocalPipe();
}
