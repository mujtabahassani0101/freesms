using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using Microsoft.Data.SqlClient;

namespace FreeSms.Core;

public sealed record DatabaseOptions(string DataDirectory, string Container = "free-sms-database", string Volume = "free-sms-data", int Port = 15436, string Name = "free_sms")
{
    public static DatabaseOptions Default => new(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "free-sms"));
}

public static class Bootstrapper
{
    public static async Task<Database> OpenAsync(string root, DatabaseOptions? options = null, IProgress<string>? progress = null, CancellationToken cancellation = default)
    {
        var configured = Environment.GetEnvironmentVariable("FREE_SMS_CONNECTION_STRING");
        if (options is null && !string.IsNullOrWhiteSpace(configured)) return new Database(configured);
        options ??= DatabaseOptions.Default;
        _ = Database.Identifier(options.Name);
        Directory.CreateDirectory(options.DataDirectory);
        var envFile = Path.Combine(options.DataDirectory, "database.env");
        if (!File.Exists(envFile))
        {
            using var stream = new FileStream(envFile, FileMode.CreateNew, FileAccess.Write, FileShare.None);
            using var writer = new StreamWriter(stream, new UTF8Encoding(false));
            await writer.WriteAsync("ACCEPT_EULA=Y\nMSSQL_PID=Developer\nMSSQL_SA_PASSWORD=Fs!" + Convert.ToHexString(RandomNumberGenerator.GetBytes(30)) + "\nMSSQL_MEMORY_LIMIT_MB=2048\n");
        }
        var password = File.ReadLines(envFile).First(line => line.StartsWith("MSSQL_SA_PASSWORD=", StringComparison.Ordinal)).Split('=', 2)[1];
        var connection = new SqlConnectionStringBuilder
        {
            DataSource = $"127.0.0.1,{options.Port}", InitialCatalog = options.Name,
            UserID = "sa", Password = password, ConnectTimeout = 3, Pooling = true,
            TrustServerCertificate = true, Encrypt = SqlConnectionEncryptOption.Optional,
            ApplicationName = "FreeSMS.NET10"
        };
        var database = new Database(connection.ConnectionString);
        progress?.Report("آماده‌سازی بانک اطلاعاتی...");
        var inspected = await Docker(false, cancellation, "container", "inspect", options.Container);
        if (inspected.Code != 0)
            await Docker(true, cancellation, "run", "-d", "--name", options.Container, "--env-file", envFile,
                "-p", $"127.0.0.1:{options.Port}:1433", "--mount", $"type=volume,src={options.Volume},dst=/var/opt/mssql",
                "--memory", "3g", "--cpus", "2", "mcr.microsoft.com/mssql/server:2019-latest");
        else if (!JsonDocument.Parse(inspected.Output).RootElement[0].GetProperty("State").GetProperty("Running").GetBoolean())
            await Docker(true, cancellation, "start", options.Container);

        for (var attempt = 0; ; attempt++)
        {
            cancellation.ThrowIfCancellationRequested();
            try { using var master = database.Open("master"); break; }
            catch (SqlException) when (attempt < 44) { await Task.Delay(1000, cancellation); }
        }
        using var server = database.Open("master");
        if (database.Scalar("SELECT DB_ID(@p0)", [options.Name], server) is null)
        {
            foreach (var (seed, target) in new[] { ("school_af_kbr_Data.MDF", options.Name + ".mdf"), ("school_af_kbr_Log.LDF", options.Name + ".ldf") })
                await Docker(true, cancellation, "cp", Path.Combine(root, "original/installed/db", seed), options.Container + ":/var/opt/mssql/data/" + target);
            await Docker(true, cancellation, "exec", "-u", "0", options.Container, "chown", "mssql:root",
                "/var/opt/mssql/data/" + options.Name + ".mdf", "/var/opt/mssql/data/" + options.Name + ".ldf");
            database.Execute($"CREATE DATABASE {Database.Identifier(options.Name)} ON (FILENAME='/var/opt/mssql/data/{options.Name}.mdf'),(FILENAME='/var/opt/mssql/data/{options.Name}.ldf') FOR ATTACH", connection: server);
        }
        return database;
    }

    private static async Task<(int Code, string Output)> Docker(bool requireSuccess, CancellationToken cancellation, params string[] arguments)
    {
        var start = new ProcessStartInfo("docker") { RedirectStandardOutput = true, RedirectStandardError = true, UseShellExecute = false, CreateNoWindow = true };
        foreach (var argument in arguments) start.ArgumentList.Add(argument);
        using var process = Process.Start(start) ?? throw new InvalidOperationException("Docker Desktop اجرا نشد.");
        var output = process.StandardOutput.ReadToEndAsync(cancellation);
        var error = process.StandardError.ReadToEndAsync(cancellation);
        using var timeout = CancellationTokenSource.CreateLinkedTokenSource(cancellation);
        timeout.CancelAfter(TimeSpan.FromMinutes(10));
        try { await process.WaitForExitAsync(timeout.Token); }
        catch { if (!process.HasExited) process.Kill(true); throw; }
        var stdout = await output;
        var stderr = await error;
        if (requireSuccess && process.ExitCode != 0) throw new InvalidOperationException("خطای Docker Desktop: " + stderr);
        return (process.ExitCode, stdout);
    }
}
