using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace FreeSms.Core;

public static partial class Migrations
{
    public const string LatestVersion = "1402/11/19";
    public static string EncodeVersion(string value)
    {
        value = Convert.ToBase64String(Encoding.UTF8.GetBytes(value));
        value = Convert.ToBase64String(Encoding.ASCII.GetBytes(value.Replace("+", "+-")));
        value = Convert.ToBase64String(Encoding.Unicode.GetBytes(value));
        return Convert.ToBase64String(Encoding.ASCII.GetBytes(value));
    }
    public static string DecodeVersion(string? value)
    {
        if (string.IsNullOrEmpty(value)) return "0000/00/00";
        value = Encoding.ASCII.GetString(Convert.FromBase64String(value));
        value = Encoding.Unicode.GetString(Convert.FromBase64String(value));
        value = DecodeUtf7Ascii(Encoding.ASCII.GetString(Convert.FromBase64String(value)));
        return Encoding.UTF8.GetString(Convert.FromBase64String(value));
    }
    // Legacy .NET UTF-7 also escaped optional ASCII characters such as '='.
    // Decode its shifted UTF-16BE groups without enabling the obsolete UTF-7 provider.
    private static string DecodeUtf7Ascii(string value) => Utf7Shift().Replace(value, match =>
    {
        var payload = match.Groups[1].Value;
        return payload.Length == 0 ? "+" : Encoding.BigEndianUnicode.GetString(Convert.FromBase64String(payload.PadRight((payload.Length + 3) / 4 * 4, '=')));
    });
    public static string Version(string resource)
    {
        var digits = Digits().Match(resource).Value;
        if (digits.Length == 6) digits = "13" + digits;
        if (digits.Length != 8) throw new InvalidDataException("Invalid migration version: " + resource);
        return digits[..4] + "/" + digits[4..6] + "/" + digits[6..8];
    }
    public static IEnumerable<string> Batches(string source) => Go().Split(source).Select(s => s.Trim()).Where(s => s.Length > 0);
    public static void Apply(Database database, string root, IProgress<string>? progress = null)
    {
        database.Execute("IF OBJECT_ID('dbo.native_migrations') IS NULL CREATE TABLE dbo.native_migrations(version varchar(20) NOT NULL PRIMARY KEY,sha256 char(64) NOT NULL,applied_at datetime2 NOT NULL DEFAULT SYSUTCDATETIME())");
        var current = DecodeVersion(Convert.ToString(database.Scalar("SELECT TOP 1 ver FROM tVer")));
        if (string.CompareOrdinal(current, LatestVersion) > 0) throw new InvalidOperationException("بانک از این نسخهٔ برنامه جدیدتر است.");
        var ledger = database.Query("SELECT version,sha256 FROM native_migrations").ToDictionary(r => r.Text("version"), r => r.Text("sha256"));
        var index = JsonSerializer.Deserialize<JsonElement[]>(File.ReadAllText(Path.Combine(root, "analysis/sql-resources/index.json"), Encoding.UTF8))!;
        foreach (var item in index.OrderBy(i => Version(i.GetProperty("resource").GetString()!), StringComparer.Ordinal))
        {
            var version = Version(item.GetProperty("resource").GetString()!);
            var text = File.ReadAllText(Path.Combine(root, item.GetProperty("file").GetString()!), Encoding.UTF8).Replace("\r\n", "\n");
            var digest = Convert.ToHexStringLower(SHA256.HashData(Encoding.UTF8.GetBytes(text)));
            if (digest != item.GetProperty("sha256").GetString() || ledger.TryGetValue(version, out var old) && old != digest)
                throw new InvalidDataException("اسکریپت بانک تغییر کرده است: " + version);
            if (string.CompareOrdinal(version, current) <= 0 || ledger.ContainsKey(version)) continue;
            progress?.Report("به‌روزرسانی بانک: " + version);
            database.Transaction((connection, transaction) =>
            {
                foreach (var batch in Batches(text)) database.Execute(batch, connection: connection, transaction: transaction);
                database.Execute("INSERT INTO native_migrations(version,sha256) VALUES(@p0,@p1)", [version, digest], connection, transaction);
                database.Execute("UPDATE tVer SET ver=@p0", [EncodeVersion(version)], connection, transaction);
                return 0;
            });
        }
        var captions = new Dictionary<int, string> { [1] = "سربرگ امتحانی - پیش فرض", [2] = "سربرگ امتحانی چند صفحه ای - پیش فرض", [3] = "دعوت نامه - پیش فرض", [4] = "فرم - پیش فرض", [5] = "کارت ورود به جلسه - پیش فرض", [6] = "کارت تبریک تولد - پیش فرض", [40] = "کارت امتحان - پیش فرض" };
        if (database.Scalar("SELECT OBJECT_ID('dbo.tRptDynamic')") is not null)
            foreach (var (id, caption) in captions)
            {
                var path = Path.Combine(root, "original/update/rpt", id + ".rpx");
                if (File.Exists(path)) database.Execute("IF NOT EXISTS(SELECT 1 FROM tRptDynamic WHERE id=@p0) INSERT INTO tRptDynamic(id,Caption,Rpt,sys,type) VALUES(@p0,@p1,@p2,1,@p3)", [id, caption, File.ReadAllBytes(path), id < 7 ? id : 4]);
            }
        database.Execute("UPDATE tVer SET ver=@p0", [EncodeVersion(LatestVersion)]);
    }
    [GeneratedRegex(@"\d+")] private static partial Regex Digits();
    [GeneratedRegex(@"\+([A-Za-z0-9+/]*)-?")] private static partial Regex Utf7Shift();
    [GeneratedRegex(@"^\s*GO\s*(?:--[^\n]*)?$", RegexOptions.Multiline | RegexOptions.IgnoreCase)] private static partial Regex Go();
}
