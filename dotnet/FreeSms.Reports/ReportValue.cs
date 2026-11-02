using System.Globalization;
using System.Xml.Linq;

namespace FreeSms.Reports;

public static class ReportValue
{
    public static string Format(XElement obj, object? value)
    {
        var format = obj.Element("number");
        if (format?.Element("DecimalPlaces") == null || value is not (byte or sbyte or short or ushort or int or uint or long or ulong or float or double or decimal)) return Formula.Text(value);
        decimal number = Convert.ToDecimal(value, CultureInfo.InvariantCulture);
        if ((bool?)format.Element("DisplayReverseSign") == true) number = -number;
        if (number == 0 && (bool?)format.Element("EnableSuppressIfZero") == true) return "";
        if (number == 0 && !string.IsNullOrEmpty((string?)format.Element("ZeroValueString"))) return format.Element("ZeroValueString")!.Value;
        int digits = Math.Clamp((int?)format.Element("DecimalPlaces") ?? 0, 0, 15);
        string rounding = (string?)format.Element("RoundingFormat") ?? "";
        string[] fractional = { "TenBillionth", "Billionth", "HundredMillionth", "TenMillionth", "Millionth", "HundredThousandth", "TenThousandth", "Thousandth", "Hundredth", "Tenth", "Unit", "Ten", "Hundred", "Thousand", "TenThousand", "HundredThousand", "Million" };
        int index = Array.FindIndex(fractional, name => rounding.EndsWith("RoundTo" + name, StringComparison.Ordinal));
        if (index >= 0)
        {
            int precision = 10 - index;
            if (precision >= 0) number = decimal.Round(number, precision, MidpointRounding.AwayFromZero);
            else { decimal unit = 1; for (int i = 0; i < -precision; i++) unit *= 10; number = decimal.Round(number / unit, 0, MidpointRounding.AwayFromZero) * unit; }
        }
        var culture = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();
        culture.NumberGroupSeparator = (string?)format.Element("ThousandSymbol") ?? ",";
        culture.NumberDecimalSeparator = (string?)format.Element("DecimalSymbol") ?? ".";
        bool grouped = (bool?)format.Element("ThousandsSeparator") ?? false;
        string text = decimal.Round(Math.Abs(number), digits, MidpointRounding.AwayFromZero).ToString((grouped ? "N" : "F") + digits, culture);
        if (Math.Abs(number) > 0 && Math.Abs(number) < 1 && (bool?)format.Element("EnableUseLeadZero") == false && text.StartsWith('0')) text = text[1..];
        string negative = (string?)format.Element("NegativeFormat") ?? "";
        if (number < 0)
        {
            if (negative.EndsWith("TrailingMinus", StringComparison.Ordinal)) text += "-";
            else if (negative.EndsWith("Bracketed", StringComparison.Ordinal)) text = "(" + text + ")";
            else if (!negative.EndsWith("NotNegative", StringComparison.Ordinal)) text = "-" + text;
        }
        return text;
    }
}
