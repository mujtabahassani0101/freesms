using System.Data;
using System.Globalization;
using System.Xml.Linq;

namespace FreeSms.Reports;

public sealed record PivotRow(string Label, decimal?[] Values, bool Total);
public sealed record PivotTable(string[] Columns, PivotRow[] Rows);

public static class ReportPivot
{
    public static PivotTable Build(XElement definition, ReportModel model, ReportInput input, DataRow[] records)
    {
        var rowExpressions = definition.Elements("row").Select(x => x.Value).ToArray();
        var columnExpressions = definition.Elements("column").Select(x => x.Value).ToArray();
        string field = (string?)definition.Attribute("field") ?? throw new InvalidDataException("Missing pivot value field.");
        string operation = (string?)definition.Attribute("operation") ?? throw new InvalidDataException("Missing pivot operation.");
        bool rowTotals = (bool?)definition.Attribute("row-totals") ?? false;
        bool columnTotals = (bool?)definition.Attribute("column-totals") ?? false;
        int subtotalLevel = (int?)definition.Attribute("subtotal-level") ?? 0;
        string[] Keys(DataRow row, string[] expressions) => expressions.Select(e => Formula.Text(model.Evaluate(e, model.Context(input, row, records)))).ToArray();
        var mapped = records.Select(r => new { Row = r, Rows = Keys(r, rowExpressions), Columns = Keys(r, columnExpressions) }).ToArray();
        var comparer = new KeyComparer();
        var columns = mapped.Select(r => r.Columns).Distinct(comparer).OrderBy(k => k, comparer).ToArray();
        var rowKeys = mapped.Select(r => r.Rows).Distinct(comparer).OrderBy(k => k, comparer).ToArray();
        decimal? Value(IEnumerable<DataRow> rows)
        {
            var values = rows.Select(r => model.Evaluate(field, model.Context(input, r, records))).Where(v => v != null).ToArray();
            if (operation == "Count") return values.Length;
            if (values.Length == 0) return null;
            var numbers = values.Select(v => Convert.ToDecimal(v, CultureInfo.InvariantCulture)).ToArray();
            return operation switch { "Average" => numbers.Average(), "Sum" => numbers.Sum(), _ => throw new InvalidDataException("Unsupported pivot operation: " + operation) };
        }
        decimal?[] Values(Func<string[], bool> match)
        {
            var data = mapped.Where(r => match(r.Rows)).ToArray();
            var values = columns.Select(c => Value(data.Where(r => comparer.Equals(r.Columns, c)).Select(r => r.Row))).ToList();
            if (rowTotals) values.Add(Value(data.Select(r => r.Row)));
            return values.ToArray();
        }
        var result = new List<PivotRow>();
        for (int index = 0; index < rowKeys.Length; index++)
        {
            var key = rowKeys[index];
            result.Add(new PivotRow(string.Join(" / ", key), Values(candidate => comparer.Equals(candidate, key)), false));
            if (subtotalLevel > 0 && (index + 1 == rowKeys.Length || !key.Take(subtotalLevel).SequenceEqual(rowKeys[index + 1].Take(subtotalLevel))))
            {
                var prefix = key.Take(subtotalLevel).ToArray();
                result.Add(new PivotRow(string.Join(" / ", prefix) + " — " + ((string?)definition.Attribute("subtotal-label") ?? "جمع"), Values(candidate => candidate.Take(subtotalLevel).SequenceEqual(prefix)), true));
            }
        }
        if (columnTotals) result.Add(new PivotRow((string?)definition.Attribute("total-row") ?? "جمع", Values(_ => true), true));
        var labels = columns.Select(c => string.Join(" / ", c)).ToList();
        if (rowTotals) labels.Add((string?)definition.Attribute("total-column") ?? "جمع");
        return new PivotTable(labels.ToArray(), result.ToArray());
    }
    private sealed class KeyComparer : IEqualityComparer<string[]>, IComparer<string[]>
    {
        public bool Equals(string[]? a, string[]? b) => a == null ? b == null : b != null && a.SequenceEqual(b, StringComparer.Ordinal);
        public int GetHashCode(string[] key) { var hash = new HashCode(); foreach (var item in key) hash.Add(item, StringComparer.Ordinal); return hash.ToHashCode(); }
        public int Compare(string[]? a, string[]? b)
        {
            if (a == null) return b == null ? 0 : -1; if (b == null) return 1;
            for (int index = 0; index < Math.Min(a.Length, b.Length); index++) { int result = string.CompareOrdinal(a[index], b[index]); if (result != 0) return result; }
            return a.Length.CompareTo(b.Length);
        }
    }
}
