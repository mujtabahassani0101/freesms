internal static class OriginalText
{
    // Keep the original database's Arabic letter forms without deleting parts
    // of names. Callers bind this text as SQL parameters.
    internal static string Normalize(string value) => (value ?? "").Trim()
        .Replace('ى', 'ي').Replace('ی', 'ي').Replace('ک', 'ك');
}
