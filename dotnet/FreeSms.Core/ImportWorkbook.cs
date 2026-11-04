using System.Data;
using System.Globalization;
using System.Text;
using ExcelDataReader;

namespace FreeSms.Core;

public enum WorkbookImportKind { Students, Marks }

// Reads the recovered Sheet1 contracts once, without an Office process or OLE DB.
// Parsing only prepares a preview; the original Save button still owns database writes.
public static class ImportWorkbook
{
    private const int MaximumRows = 100_000, MaximumColumns = 256;
    private const long MaximumBytes = 64L * 1024 * 1024;
    private static readonly string[] StudentFields = ["sort", "code", "paye", "class", "name", "family", "father", "jens", "numberasas", "mainfees", "stdfees", "stdfeeskoll", "payment", "dakhele", "exam", "uniform", "mobilefather", "mobilemother"];
    private static readonly string[] MarkFields = ["code", "codedars", "mark"];

    public static DataTable Read(string path, WorkbookImportKind kind)
    {
        if (kind is not WorkbookImportKind.Students and not WorkbookImportKind.Marks)
            throw new ArgumentOutOfRangeException(nameof(kind));
        if (!new[] { ".xls", ".xlsx" }.Contains(Path.GetExtension(path), StringComparer.OrdinalIgnoreCase))
            throw new ValidationException("فایل اکسل با پسوند xls یا xlsx را انتخاب کنید.");
        using var stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
        if (stream.Length > MaximumBytes) throw new ValidationException("حجم فایل اکسل بیشتر از ۶۴ مگابایت است.");
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        try
        {
            using var reader = ExcelReaderFactory.CreateReader(stream, new ExcelReaderConfiguration { LeaveOpen = true });
            do
            {
                if (string.Equals(reader.Name, "Sheet1", StringComparison.OrdinalIgnoreCase)) return ReadSheet(reader, kind);
            } while (reader.NextResult());
            throw new ValidationException("برگهٔ Sheet1 در فایل اکسل وجود ندارد.");
        }
        catch (Exception error) when (error is not ValidationException and not IOException and not OutOfMemoryException)
        {
            throw new ValidationException("فایل اکسل قابل خواندن نیست؛ فایل سالم و بدون گذرواژه را انتخاب کنید.");
        }
    }

    private static DataTable ReadSheet(IExcelDataReader reader, WorkbookImportKind kind)
    {
        if (reader.FieldCount > MaximumColumns || reader.RowCount > MaximumRows + 1)
            throw new ValidationException("فایل اکسل بیشتر از ۱۰۰۰۰۰ ردیف یا ۲۵۶ ستون دارد.");
        if (!reader.Read()) throw new ValidationException("برگهٔ Sheet1 خالی است.");
        var table = new DataTable("Sheet1") { Locale = CultureInfo.InvariantCulture };
        var columns = new DataColumn?[reader.FieldCount];
        var names = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        string Text(int column)
        {
            if (reader.GetCellError(column) is not null)
                throw new ValidationException($"خانهٔ اکسل در ردیف {reader.Depth + 1} و ستون {column + 1} خطا دارد.");
            var value = reader.GetValue(column);
            return value is DateTime date ? date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)
                : Convert.ToString(value, CultureInfo.InvariantCulture) ?? "";
        }
        for (int column = 0; column < columns.Length; column++)
        {
            string name = Text(column).Trim().TrimStart('\uFEFF').ToLowerInvariant();
            if (name.Length == 0) continue; // Blank formatted trailing columns are common in the original XLS templates.
            if (name is "acp" or "status" || !names.Add(name))
                throw new ValidationException("عنوان ستون تکراری یا رزروشده است: " + name);
            columns[column] = table.Columns.Add(name, typeof(string));
        }
        var missing = (kind == WorkbookImportKind.Students ? StudentFields : MarkFields).Where(field => !names.Contains(field)).ToArray();
        if (missing.Length != 0) throw new ValidationException("ستون‌های لازم در فایل اکسل وجود ندارند: " + string.Join(", ", missing));
        while (reader.Read())
        {
            if (reader.Depth > MaximumRows) throw new ValidationException("فایل اکسل بیشتر از ۱۰۰۰۰۰ ردیف دارد.");
            var row = table.NewRow();
            bool populated = false;
            for (int column = 0; column < columns.Length; column++)
            {
                string value = Text(column);
                if (string.IsNullOrWhiteSpace(value)) continue;
                if (columns[column] is not DataColumn target)
                    throw new ValidationException($"ستون {column + 1} عنوان ندارد؛ ردیف {reader.Depth + 1} را بررسی کنید.");
                row[target] = value;
                populated = true;
            }
            if (!populated || kind == WorkbookImportKind.Students && row.IsNull("class")) continue;
            table.Rows.Add(row);
        }
        table.Columns.Add("acp", typeof(string));
        table.Columns.Add("status", typeof(string));
        return table;
    }
}
