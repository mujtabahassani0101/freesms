using System.Globalization;

namespace FreeSms.Core;

public sealed class Record : Dictionary<string, object?>
{
    public Record() : base(StringComparer.OrdinalIgnoreCase) { }
    public object? Value(string key) => this.GetValueOrDefault(key);
    public string Text(string key) => Convert.ToString(Value(key), CultureInfo.InvariantCulture) ?? "";
    public int Int(string key) => Convert.ToInt32(Value(key), CultureInfo.InvariantCulture);
}

public sealed class ValidationException(string message) : Exception(message);

public static class Values
{
    public static string Text(object? value) => (Convert.ToString(value, CultureInfo.InvariantCulture) ?? "")
        .Trim().Replace('ي', 'ی').Replace('ك', 'ک');

    public static int? Number(object? value, int? minimum = null, int? maximum = null)
    {
        var text = Text(value);
        if (text.Length == 0) return null;
        const string digits = "۰۱۲۳۴۵۶۷۸۹٠١٢٣٤٥٦٧٨٩";
        text = string.Concat(text.Select(c => digits.IndexOf(c) is var i && i >= 0 ? (char)('0' + i % 10) : c));
        if (!int.TryParse(text, NumberStyles.Integer, CultureInfo.InvariantCulture, out var result))
            throw new ValidationException("مقدار عددی معتبر وارد کنید.");
        if (minimum is not null && result < minimum || maximum is not null && result > maximum)
            throw new ValidationException("مقدار عددی خارج از محدودهٔ مجاز است.");
        return result;
    }

    public static long? LongNumber(object? value,long? minimum=null,long? maximum=null)
    {
        string text=Text(value);if(text.Length==0)return null;
        const string digits="۰۱۲۳۴۵۶۷۸۹٠١٢٣٤٥٦٧٨٩";
        text=string.Concat(text.Select(character=>digits.IndexOf(character) is var index && index>=0?(char)('0'+index%10):character));
        if(!long.TryParse(text,NumberStyles.Integer,CultureInfo.InvariantCulture,out long number))throw new ValidationException("مقدار عددی معتبر وارد کنید.");
        if(minimum is not null && number<minimum || maximum is not null && number>maximum)throw new ValidationException("مقدار عددی خارج از محدودهٔ مجاز است.");
        return number;
    }

    public static bool Boolean(object? value) => value is bool boolean ? boolean : Number(value) is not null and not 0;
}
