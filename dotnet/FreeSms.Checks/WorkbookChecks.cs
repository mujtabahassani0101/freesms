using System.Data;
using FreeSms.Core;

internal static class WorkbookChecks
{
    internal static void Verify(string root, Action<string, Action> check)
    {
        string fixtures = Path.Combine(root, "validation", "functional", "workbooks");
        check("Office-free OOXML student preview reads each row once, keeps quotes/leading zeros and skips only blank/no-class rows", () =>
        {
            var table = ImportWorkbook.Read(Path.Combine(fixtures, "students-valid.xlsx"), WorkbookImportKind.Students);
            if (table.Rows.Count != 2 || (string)table.Rows[0]["code"] != "001234" || (string)table.Rows[1]["code"] != "۱۲۳۵"
                || (string)table.Rows[0]["name"] != "نام ' آزمون" || (string)table.Rows[0]["mobilefather"] != "0700000000"
                || table.Columns.Cast<DataColumn>().Any(column => column.DataType != typeof(string))) throw new Exception("Student workbook values/count changed.");
        });
        check("Office-free OOXML mark preview keeps zero, fractions, empty values and the Sheet1 contract", () =>
        {
            var table = ImportWorkbook.Read(Path.Combine(fixtures, "marks-valid.xlsx"), WorkbookImportKind.Marks);
            if (table.Rows.Count != 3 || (string)table.Rows[0]["code"] != "001234" || (string)table.Rows[0]["mark"] != "25.5"
                || (string)table.Rows[1]["mark"] != "0" || !table.Rows[2].IsNull("mark")) throw new Exception("Mark workbook values/count changed.");
            if (ImportWorkbook.Read(Path.Combine(fixtures, "marks-empty.xlsx"), WorkbookImportKind.Marks).Rows.Count != 0) throw new Exception("Empty workbook gained a row.");
        });
        check("Malformed Excel contracts, cell errors, duplicate/reserved/unnamed headers and missing Sheet1 reject before any preview is returned", () =>
        {
            foreach (string name in new[] { "corrupt", "duplicate-header", "missing-header", "unnamed-data", "reserved-header", "cell-error", "missing-sheet" })
            {
                try { ImportWorkbook.Read(Path.Combine(fixtures, name + ".xlsx"), WorkbookImportKind.Marks); }
                catch (ValidationException) { continue; }
                throw new Exception("Accepted malformed workbook: " + name);
            }
        });
        check("Recovered binary XLS student/mark examples parse without ACE, Jet or Excel", () =>
        {
            string directory = Path.Combine(root, "dotnet", "FreeSms.Original.Windows");
            foreach (var item in new[] { ("xls/Example.xls", WorkbookImportKind.Students), ("xls/ExampleMark.xls", WorkbookImportKind.Marks) })
            {
                var table = ImportWorkbook.Read(Path.Combine(directory, item.Item1), item.Item2);
                if (table.Columns.Count < 5) throw new Exception("Recovered XLS contract was lost: " + item.Item1);
            }
        });
    }
}
